﻿using System;
using System.Threading.Tasks;

using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace IEthereumAPI
{
    public class ERC721_TotalSupply : IEthereumApi
    {
        private static ERC721_TotalSupply _instance = null;
        public static ERC721_TotalSupply Instance
        {
            get
            {
                if (_instance == null) { _instance = new ERC721_TotalSupply(); }
                return _instance;
            }
        }

        [Function("totalSupply", "uint256")]
        public class TotalSupplyFunction : FunctionMessage{}

        private async Task Logic(string contractAddress)
        {
            var abi = new TotalSupplyFunction(){};

            var handler = IEthereumStatus.Instance._web3.Eth.GetContractQueryHandler<TotalSupplyFunction>();

            try
            {
                var value = await handler.QueryAsync<object>(contractAddress, abi);

                result = value.ToString();
                status = true;
            }
            catch (Exception e)
            {
                result = e.Message.ToString();
                status = false;
            }
        }

        public async Task<Tuple<string, bool>> Call(string contractAddress)
        {
            Init();
            await Logic(contractAddress);

            return new Tuple<string, bool>(result, status);
        }
    }
}
