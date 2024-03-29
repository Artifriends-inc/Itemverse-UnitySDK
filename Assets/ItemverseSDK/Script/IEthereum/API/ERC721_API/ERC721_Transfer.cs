﻿using System;
using System.Numerics;
using System.Threading.Tasks;

using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3.Accounts;
using Nethereum.Contracts;

namespace IEthereumAPI
{
    public class ERC721_Transfer : IEthereumApi
    {
        private static ERC721_Transfer _instance = null;
        public static ERC721_Transfer Instance
        {
            get
            {
                if (_instance == null) { _instance = new ERC721_Transfer(); }
                return _instance;
            }
        }

        [Function("transferFrom", "bool")]
        public class TransferFunction : FunctionMessage
        {
            [Parameter("address", "_from", 1)]
            public string From { get; set; }

            [Parameter("address", "_to", 2)]
            public string To { get; set; }

            [Parameter("uint256", "_tokenId", 3)]
            public BigInteger TokenId { get; set; }
        }

        private async Task Logic(string privateKey, string toAddress, BigInteger tokenId, string contractAddress)
        {
            try
            {
                // check privateKey
                IEthereumUtil.Instance.CheckPrivateKey(privateKey);
                // check toAddress
                IEthereumUtil.Instance.CheckAddress(toAddress);
                // check contract address
                IEthereumUtil.Instance.CheckAddress(contractAddress);

                Account account = new Account(privateKey);
                IEthereumUtil.Instance.LoginWeb3(privateKey);

                var abi = new TransferFunction()
                {
                    From = account.Address,
                    To = toAddress,
                    TokenId = tokenId
                };

                var handler = IEthereumStatus.Instance._web3.Eth.GetContractTransactionHandler<TransferFunction>();

                var value = await handler.SendRequestAsync(contractAddress, abi);

                result = value.ToString();
                status = true;
            }
            catch (Exception e)
            {
                result = e.Message.ToString();
                status = false;
            }
        }

        public async Task<Tuple<string, bool>> Call(string privateKey, string toAddress, BigInteger tokenId, string contractAddress)
        {
            Init();
            await Logic(privateKey, toAddress, tokenId, contractAddress);

            return new Tuple<string, bool>(result, status);
        }
    }
}
