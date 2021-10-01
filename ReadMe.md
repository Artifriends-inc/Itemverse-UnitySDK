# ItemNet Unity SDK

### Introduction

This is an integrated blockchain Unity SDK for blockchain game development. All data used in the game, such as in-game asset management, game items and user information storage, can be safely managed with blockchain. Supports Ethereum and SASEUL blockchain.

#### Ethereum

You can use ETH and ERC-20 tokens from Ethereum to replace in-game money, and ERC-721 (NFT) tokens to manage in-game objects. However, it is not suitable to use Ethereum for games. When using Ethereum for games, please consider these following problems.

1. **Transaction charges**: Sending ETH, generating tokens, transferring tokens, storing data, etc. are all required to pay Ethereum fees.
2. **Low speed:** It takes more than 1 minute for data to be stored in Ethereum, so it is not suitable for platforms such as games.
3. **Instability:** Depending on the state of the Ethereum network, operations such as sending and uploading data often fail.
4. **Limited storage capacity:** Large data such as image data cannot be saved.

#### SASEUL

SASEUL is a third-generation blockchain engine that has solved the chronic problems of previous blockchain engines. It has the following differences from previous blockchain engines. If you want to learn more about the SASEUL, please visit our website https://www.saseul.com.

1. **No transaction fee:** All functions such as generating tokens, transferring tokens, storing data, etc. are free of charge
2. **Full functionality:** All existing blockchain functionalities such as ERC-20 and ERC-721(NFT) are available
3. **High speed:** It takes less than 1 second to upload data
4. **Sufficient native storage:** Can store data up to 20mb
5. **Stability:** Stable network and continuous update and management

------

### Platforms Supported

- Unity
  - 2019.4(LTS)
  - 2020.3(LTS)
  - 2021.1
- Platform
  - Android
  - IOS
  - MacOs
  - Windows
- Etc
  - .NET 4.X

------

### Installation

1. Install the ItemNet Unity package.

2. Open your Unity project and import the ItemNet Unity package.
    - In 2020.3 (LTS) and 2021.1 versions, exclude Newtonsoft.Json.dll in the Plugins folder. In these versions, the collab-proxy (Unity Collaborator) package is installed by default and this package contains Newtonsoft.Json.dll, which causes plug-in conflicts.

      <img src="https://user-images.githubusercontent.com/49587288/122674994-7b037300-d212-11eb-8dd0-c88775f9107a.png"/>

3. Open the "Demo" scene.

4. If you select ItemNetStatus, ItemNetExample, IEthereumStatus, IEthereumExample objects in the Hierarchy view, you will see inspector view on the right side. On the script components in the inspector view, you can set each network and test data.

    - Ethereum configuration
      - Ethereum network configuration

        <img src="https://user-images.githubusercontent.com/49587288/122644965-c22a2f00-d152-11eb-87a4-421d16ede7cf.png"/>

        As shown in the image above, if you select the "IEthereumStatus" object in the Hierarchy view, the Ethereum network settings are displayed in the "IEthereumStatus" script component in the Inspector view. Please set it by referring to the option description below.

        **options**

        - NetType: Enter one of three values: "ropsten", "main", "etc".
          - ropsten: Ethereum's Ropsten test network.
          - main: Ethereum's main network.
          - etc: User's custom network.
        - Main Infura Url, Ropsten Infura Url
          - Sign up infura ( https://www.infura.io ) and enter the rpc url of each network.
      - Ethereum test data setup

        ![스크린샷 2021-06-19 오후 8.14.03](https://user-images.githubusercontent.com/49587288/122644978-d3733b80-d152-11eb-80e0-1eaeee18d347.png)

        As shown in the image above, if you select the "IEthereumExample" object in the Hierarchy view, the Ethereum test data settings are displayed in the "IEthereumExample" script component in the Inspector view. Please set it by referring to the options description below.

        **options**

        - PrivateKey: Private key of Ethereum account.
        - Address: Address of Ethereum account.
        - To Address: Address of the counterpart Ethereum account.
        - Token Amount: Amount of ERC-20 tokens to send for ERC-20 token transfer test.
        - ERC721 Token Id: ERC721 token ID for token information inquiry and token transfer, etc.
        - ERC721 Token Index: Index of ERC-721 token to inquire for token information inquiry, etc.
        - Block Number: Number of the block to inquire.
        - Transaction Hash: Transaction hash to inquire.
        - ERC20 ContractAddress: Contract address of the ERC-20 token.
        - ERC721 ContractAddress: Contract address of the ERC-721 token.
    - SASEUL configuration
      - SASEUL network configuration

        ![스크린샷 2021-06-19 오후 9.29.23](https://user-images.githubusercontent.com/49587288/122645014-f998db80-d152-11eb-9b64-a80952f6fbd7.png)

        As shown in the image above, if you select the "ItemNetStatus" object in the Hierarchy view, you will see the SASEUL network settings in the "ItemNetStatus" script component in the Inspector view. Please set it by referring to the options description below.

        **options**

        - NetType: Enter one of "main" and "etc" values.
          - main: main network of the SASEUL.
          - etc: You can use it when you want to register an additional SASEUL network.
        - Main Url, Etc Url
          - You can check the url of each network by accessing ItemNet Explorer ( https://explorer.itemverse.io/ ).
        - Version
          - Enter the version of the SASEUL you want to use.
      - SASEUL test data configuration

        ![스크린샷 2021-06-19 오후 9.29.29](https://user-images.githubusercontent.com/49587288/122645035-1a613100-d153-11eb-9821-c653e78b455e.png)

        As shown in the image above, when the "ItemNetExample" object in the Hierarchy view is selected, the SASEUL test data settings appear in the "ItemNetExample" script component in the Inspector view. Please set the options by referring to the option descriptions below.

        **options**

        - PrivateKey: Private key of SASEUL account.
        - PublicKey: Public key of SASEUL account.
        - Address: Address of SASEUL account.
        - NFTUUID: ID of ERC721 (NFT) token.
        - Page: Specifies the number of pages for the ListNFT function.
        - Count: Specifies the number of outputs for the ListNFT function.
        - Sort: Specifies the sort type or the ListNFT function.
          - "1": ascending order
          - "-1": descending order
        - NFT Class: Group name of the token for generating ERC-721 (NFT) tokens.
        - NFT Name: Name of the token for generating ERC-721 (NFT) tokens.
        - NFT Thumbnail: Thumbnail of the token for generating ERC-721 (NFT) tokens.
        - NFT Description: Token description for generating ERC-721 (NFT) tokens.
        - NFT Image: An image of a token for generating ERC-721 (NFT) tokens.

5. In the Game tab, set the screen size to 1024 x 768 and run.

    ![스크린샷 2021-06-19 오후 9.56.51](https://user-images.githubusercontent.com/49587288/122645047-2baa3d80-d153-11eb-8233-a47a686a501e.png)

6. Test the Ethereum and SASEUL blockchain functions by clicking the buttons. You can change the blockchain to be tested by pressing the Change button and copy the entire result by pressing the Copy button.

    ![스크린샷 2021-06-19 오후 9.58.01](https://user-images.githubusercontent.com/49587288/122645058-3a90f000-d153-11eb-8717-1ecdb239ecfa.png)
    
7. When applying ItemNet Unity SDK in a new project, add "IEthereumStatus", "ItemNetStatus" Prefabs in the ItemverseSDK/Prefab path to the new project, and refer to IEthereumExample.cs and ItemNetExample.cs in the demo to use the APIs of each network.

    ![스크린샷 2021-07-22 오후 3 09 06](https://user-images.githubusercontent.com/49587288/126596533-a1fbd286-b456-457c-a0a7-b85c2d7760b3.png)

8. Useful sites for Ethereum test.
    1. Issuance of test Ethereum: https://faucet.ropsten.be/
    2. Issuance of test Ethereum tokens(ERC-721) : https://faucet.itemverse.saseul.com/fauceterc721.html
    3. Issuance of test Ethereum tokens(ERC-20) :  https://erc20faucet.com/
    4. Test Ethereum Explorer: https://ropsten.etherscan.io/

9. Useful sites for SASEUL test.
    1. SASEUL Explorer: https://explorer.itemverse.io/
    2. SASEUL official site: https://saseul.com/#/
    3. Developer site: https://artifriends.com/
    4. SDK official introduction site: https://itemverse.io/

------

### API

#### Ethereum

- **API:** ItemverseSDK/Script/IEthereum/API/*
  
- **example:** ItemverseSDK/Demo/Script/IEthereumExample.cs

- **Ethereum**

  - **GetBalance**

    - Description

      Inquire ETH balance.

    - Query Parameters

      | Field  | Type  | Description | Default Value |
      | ------- | ------ | ----------- | ------------- |
      | address | string | account address  |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | -------------- | ------------- |
      | result | string | balance  |  |
      | status | bool  | request status |  |

  - **GetBlockByNumber**

    - Description

      Get block data by block index.

    - Query Parameters

      | Field  | Type  | Description | Default Value |
      | ----------- | ------------- | ----------- | ------------- |
      | blockNumber | HexBigInteger | block index  |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | -------------- | ------------- |
      | result | string | block data  |  |
      | status | bool  | request status |  |

  - **GetLatestBlockNumber**

    - Description

      Get the total number of blocks stacked on the Ethereum network

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | -------------- | ------------- |
      | result | string | total number of blocks  |  |
      | status | bool  | request status |  |

  - **GetTransactionByHash**

    - Description

      Get transaction data from transaction hash.

    - Query Parameters

      | Field  | Type  | Description  | Default Value |
      | --------------- | ------ | ------------- | ------------- |
      | transactionHash | string | transaction hash |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | --------------- | ------------- |
      | result | string | transaction data |  |
      | status | bool  | request status  |  |

  - **GetTransactionReceipt**

    - Description

      Get the transaction receipt data from the transaction hash.

    - Query Parameters

      | Field  | Type  | Description  | Default Value |
      | --------------- | ------ | ------------- | ------------- |
      | transactionHash | string | transaction hash |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | ---------------------- | ------------- |
      | result | string | transaction receipt data |  |
      | status | bool  | request status  |  |

  
  - **Transfer**

    - Description

      Send ETH.

    - Query Parameters

      | Field  | Type  | Description | Default Value |
      | ---------- | ------- | ----------- | ------------- |
      | privateKey | string  | account private key |  |
      | toAddress  | string  | recipient address |  |
      | amount  | decimal | amount(eth unit)  |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | -------------- | ------------- |
      | result | string | transfer result  |  |
      | status | bool  | request status |  |

- **ERC20**

    - **ERC20_GetBalance**

      - Description

        Inquire ERC-20 token balance.

      - Query Parameters

        | Field  | Type  | Description  | Default Value |
        | --------------- | ------ | -------------------- | ------------- |
        | address  | string | account address  |  |
        | contractAddress | string | ERC-20 contract address |  |

      - Response

        | Field  | Type  | Description  | Default Value |
        | ------ | ------ | --------------------- | ------------- |
        | result | string | ERC-20 token balance |  |
        | status | bool  | request status  |  |

    - **ERC20_Name**

      - Description

        Inquire the name of ERC-20 token.

      - Query Parameters

        | Field  | Type  | Description  | Default Value |
        | --------------- | ------ | -------------------- | ------------- |
        | contractAddress | string | ERC-20 contract address |  |

      - Response

        | Field  | Type  | Description  | Default Value |
        | ------ | ------ | ---------------- | ------------- |
        | result | string | ERC-20 token name |  |
        | status | bool  | request status  |  |

  - **ERC20_Symbol**

    - Description

      Inquire the symbol of ERC-20 token.

    - Query Parameters

      | Field  | Type  | Description  | Default Value |
      | --------------- | ------ | -------------------- | ------------- |
      | contractAddress | string | ERC-20 contract address |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | ---------------- | ------------- |
      | result | string | ERC-20 token symbol |  |
      | status | bool  | request status  |  |

  - **ERC20_TotalSupply**

    - Description

      Inquire the total issuance of ERC-20 tokens.

    - Query Parameters

      | Field  | Type  | Description  | Default Value |
      | --------------- | ------ | -------------------- | ------------- |
      | contractAddress | string | ERC-20 contract address |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | --------------------- | ------------- |
      | result | string | ERC-20 total token issuance |  |
      | status | bool  | request status  |  |

  - **ERC20_Transfer**

    - Description

      Send a ERC-20 token.

    - Query Parameters

      | Field  | Type  | Description  | Default Value |
      | --------------- | ---------- | -------------------- | ------------- |
      | privateKey  | string  | private key of the sender account  |  |
      | toAddress  | string  | recipient address  |  |
      | tokenAmount  | BigInteger | ERC-20 token amount  |  |
      | contractAddress | string  | ERC-20 contract address |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | --------------------- | ------------- |
      | result | string | ERC-20 transfer result |  |
      | status | bool  | request status  |  |

- **ERC721**

  - **ERC721_GetBalance**

    - Description

      Inquire ERC-721 token balance.

    - Query Parameters

      | Field  | Type  | Description  | Default Value |
      | --------------- | ------ | --------------------- | ------------- |
      | address  | string |account address  |  |
      | contractAddress | string | ERC-721 contract address |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | ----------------- | ------------- |
      | result | string | ERC-721 token balance |  |
      | status | bool  | request status  |  |

  - **ERC721_Name**

    - Description

      Inquire ERC-721 token name.

    - Query Parameters

      | Field  | Type  | Description  | Default Value |
      | --------------- | ------ | --------------------- | ------------- |
      | contractAddress | string | ERC-721 contract address |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | ----------------- | ------------- |
      | result | string | ERC-721 token name |  |
      | status | bool  | request status  |  |

  - **ERC721_OwnerOf**

    - Description

      Inquire the owner by ERC-721 token Id.

    - Query Parameters

      | Field  | Type  | Description  | Default Value |
      | --------------- | ---------- | --------------------- | ------------- |
      | tokenId  | BigInteger | ERC-721 token Id  |  |
      | contractAddress | string  | ERC-721 contract address |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | ------------------- | ------------- |
      | result | string | ERC-721 token owner |  |
      | status | bool  | request status  |  |

  - **ERC721_Symbol**

    - Description

      Inquire the ERC-721 token symbol.

    - Query Parameters

      | Field  | Type  | Description  | Default Value |
      | --------------- | ------ | --------------------- | ------------- |
      | contractAddress | string | ERC-721 contract address |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | ----------------- | ------------- |
      | result | string | ERC-721 token symbol |  |
      | status | bool  | request status  |  |

  - **ERC721_TokenOfOwnerByIndex**

    - Description

      Inquire the ERC-721 token Id owned by the account from the index.

    - Query Parameters

      | Field  | Type  | Description  | Default Value |
      | --------------- | ------ | --------------------- | ------------- |
      | address  | string | account address  |  |
      | index  | string | ERC-721 token index  |  |
      | contractAddress | string | ERC-721 contract address |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | --------------- | ------------- |
      | result | string | ERC-721 token id |  |
      | status | bool  | request status  |  |

  - **ERC721_TokenURI**

    - Description

      Inquire the ERC-721 metadata URI of the token from the ERC-721 token ID.

    - Query Parameters

      | Field  | Type  | Description  | Default Value |
      | --------------- | ---------- | --------------------- | ------------- |
      | tokenId  | BigInteger | ERC-721 token Id  |  |
      | contractAddress | string  | ERC-721 contract address |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | --------------- | ------------- |
      | result | string | ERC-721 token metadata URI |  |
      | status | bool  | request status  |  |

  - **ERC721_TotalSupply**

    - Description

      Inquire the total issuance of ERC-721 tokens.

    - Query Parameters

      | Field  | Type  | Description  | Default Value |
      | --------------- | ------ | --------------------- | ------------- |
      | contractAddress | string | ERC-721 contract address |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | ---------------------- | ------------- |
      | result | string | total issuance of ERC-721 tokens |  |
      | status | bool  | request status  |  |

  - **ERC721_Transfer**

    - Description

      Send a ERC-721 token.

    - Query Parameters

      | Field  | Type  | Description  | Default Value |
      | --------------- | ---------- | --------------------- | ------------- |
      | privateKey  | string  | private key of the sending account  |  |
      | toAddress  | string  | recipient address  |  |
      | tokenId  | BigInteger | ERC-721 token id  |  |
      | contractAddress | string  | ERC-721 contract address |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | ---------------------- | ------------- |
      | result | string | ERC-721 token transfer result |  |
      | status | bool  | request status  |  |

#### SASEUL

  - **API:** ItemverseSDK/Script/ItemNet/API/*

  - **example:** ItemverseSDK/Demo/Script/ItemNetExample.cs

  - **API document:** https://docs.itemverse.io

  - **<u>note:</u>** Except for the APIs below, APIs such as CreateNFT have been added temporarily. The temporary API is subject to change with future updates.

  - **SendRequest**

    - Description

        Request SASEUL API

    - Query Parameters

      | Field  | Type  | Description  | Default Value |
      | ----------- | ------ | --------------- | ------------- |
      | requestData | string | api request data |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | -------------- | ------------- |
      | result | string | api request result  |  |
      | status | bool  | request status |  |

  - **SendTransaction**

    - Description

      Send a transaction to SASEUL

    - Query Parameters

      | Field  | Type  | Description  | Default Value |
      | --------------- | ------ | ------------------------ | ------------- |
      | privateKey  | string | Private key to sign transaction |  |
      | transactionData | string | transaction data  |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | ------------------ | ------------- |
      | result | string | Transaction transfer result |  |
      | status | bool  | request status  |  |

  - **SendRawTransaction**

    - Description

        Send a signed transaction to SASEUL.

    - Query Parameters

      | Field  | Type  | Description  | Default Value |
      | ----------- | ------ | --------------- | ------------- |
      | transaction | string | signed transaction |  |
      | thash  | string | signed transaction hash  |  |
      | publicKey  | string | public key of the account  |  |
      | signature  | string | signed data  |  |

    - Response

      | Field  | Type  | Description  | Default Value |
      | ------ | ------ | ----------------------- | ------------- |
      | result | string | transaction transfer result |  |
      | status | bool  | request status  |  |

------

###
