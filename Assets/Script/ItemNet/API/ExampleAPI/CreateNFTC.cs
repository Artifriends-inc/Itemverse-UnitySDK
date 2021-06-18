﻿using System;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace SASEULAPI
{
    public class CreateNFTC : SaseulApi
    {
        private static CreateNFTC _instance = null;
        public static CreateNFTC Instance
        {
            get
            {
                if (_instance == null) { _instance = new CreateNFTC(); }
                return _instance;
            }
        }

        private class CreateNFTCStructure
        {
            public string type;
            public long timestamp;
        }

        private async Task Logic(string privateKey)
        {
            await Task.Run(() =>
            {
                CreateNFTCStructure structure = new CreateNFTCStructure();

                string publicKey = SASEULEnc.MakePublicKey(privateKey);
                string address = SASEULEnc.MakeAddress(publicKey);

                structure.type = "CreateNFTC";
                structure.timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds() * 1000;

                string transaction = JsonConvert.SerializeObject(structure);
                string thash = SASEULEnc.THash(transaction);
                string signature = SASEULEnc.MakeSignature(thash, privateKey);

                form.AddField("transaction", transaction);
                form.AddField("thash", thash);
                form.AddField("public_key", publicKey);
                form.AddField("signature", signature);
            });
        }

        public async Task<Tuple<string, bool>> Call(string privateKey)
        {
            Init();
            await Logic(privateKey);
            await Send("/sendtransaction");

            return new Tuple<string, bool>(result, status);
        }
    }
}