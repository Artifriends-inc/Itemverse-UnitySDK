﻿using System;
using System.Numerics;
using System.Threading.Tasks;

using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace IEthereumAPI
{
    public class ERC721_OwnerOf : IEthereumApi
    {
        private static ERC721_OwnerOf _instance = null;
        public static ERC721_OwnerOf Instance
        {
            get
            {
                if (_instance == null) { _instance = new ERC721_OwnerOf(); }
                return _instance;
            }
        }

        [Function("ownerOf", "address")]
        public class OwnerOfFunction : FunctionMessage
        {
            [Parameter("uint256", "_tokenId", 1)]
            public BigInteger TokenId { get; set; }
        }

        private async Task Logic(BigInteger tokenId, string contractAddress)
        {
            try
            {
                // check contract address
                IEthereumUtil.Instance.CheckAddress(contractAddress);

                var abi = new OwnerOfFunction()
                {
                    TokenId = tokenId,
                };

                var handler = IEthereumStatus.Instance._web3.Eth.GetContractQueryHandler<OwnerOfFunction>();

                var value = await handler.QueryAsync<string>(contractAddress, abi);

                result = value.ToString();
                status = true;
            }
            catch (Exception e)
            {
                result = e.Message.ToString();
                status = false;
            }
        }

        public async Task<Tuple<string, bool>> Call(BigInteger tokenId, string contractAddress)
        {
            Init();
            await Logic(tokenId, contractAddress);

            return new Tuple<string, bool>(result, status);
        }
    }
}
