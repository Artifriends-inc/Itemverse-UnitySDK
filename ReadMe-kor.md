# ItemNet Unity SDK

### SDK 소개

블록체인 게임개발을 위한 통합 블록체인 유니티 SDK입니다. 게임 내 재화 관리, 게임 아이템 및 유저의 정보 저장 등 게임에 사용되는 모든 데이터를 블록체인으로 안전하게 관리할 수 있습니다. 이더리움 및 사슬 블록체인을 지원합니다.

#### Ethereum

이더리움의 ETH와 ERC-20 토큰을 사용하여 게임 내 재화를 대신 할 수 있고, ERC-721(NFT) 토큰을 사용하여 게임 내 오브젝트들을 관리 할 수 있습니다. 하지만 이더리움을 게임에 사용하는건 적합하지 않습니다. 이더리움을 게임에 사용할 때 아래와 같은 문제점이 있으니 꼭 고려하시기 바랍니다.

1. 이더리움 송금, 토큰 생성, 토큰 전송, 데이터 저장 등 모든 작업에 이더리움 수수료가 발생하여 큰 부담이 됩니다.
2. 이더리움에 데이터가 저장되는 시간은 기본적으로 1 분 이상이 소요되어 게임과 같은 플랫폼에서는 적합하지 않습니다.
3. 이더리움 네트워크 상태에 따라 송금, 데이터 업로드등의 작업들이 자주 실패할 때가 있습니다.
4. 이미지 데이터와 같이 용량이 큰 데이터는 저장할 수 없습니다.

#### Saseul

사슬은 이전 블록체인들의 고질적인 문제를 해결한 3세대 블록체인 엔진입니다. 이전 블록체인과 아래와 같은 차이점이 있으며 사슬에 대해 더 자세히 알아보고싶다면 https://www.saseul.com 을 방문하시길 바랍니다.

1. 토큰 생성, 토큰 송금, 데이터 저장 등 모든 기능들이 수수료 없이 무료
2. ERC-20, ERC-721(NFT) 등 기존의 블록체인 기능들 모두 사용 가능
3. 1 초 미만의 데이터 업로드 소요시간
4. 최대 20mb까지 데이터 저장 가능
5. 안정적인 네트워크와 지속적인 업데이트 및 관리

------

### 사양

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

### 설치

1. ItemNet 유니티 패키지를 설치합니다.

2. 유니티 프로젝트를 열고 ItemNet 유니티 패키지를 임포트합니다.
   - 2020.3(LTS), 2021.1 버전에서는 Plugins 폴더의 Newtonsoft.Json.dll을 제외합니다. 이 버전들에서는 기본적으로 collab-proxy(유니티 콜라보레이터) 패키지가 설치되는데 이 패키지가 Newtonsoft.Json.dll을 포함하고 있어 플러그인 충돌문제가 발생하기 때문입니다.
   
     <img src="https://user-images.githubusercontent.com/49587288/122674994-7b037300-d212-11eb-8dd0-c88775f9107a.png"/>
   
3. "Demo" Scene을 열어줍니다.

4. Hierarchy 뷰의 ItemNetStatus, ItemNetExample, IEthereumStatus, IEthereumExample 오브젝트를 선택하면 나오는 Inspector 뷰에 스크립트 컴포넌트들에서 각 네트워크 및 테스트 데이터 설정을 할 수 있습니다.

   - 이더리움 설정
     - 이더리움 네트워크 설정

       <img src="https://user-images.githubusercontent.com/49587288/122644965-c22a2f00-d152-11eb-87a4-421d16ede7cf.png"/>

       위에 이미지와 같이 Hierarchy 뷰에서 "IEthereumStatus" 오브젝트를 선택하면 Inspector 뷰에 "IEthereumStatus" 스크립트 컴포넌트에서 이더리움 네트워크 설정값이 나옵니다. 아래의 옵션 설명을 참고하여 설정해주세요.

       **옵션**

       - NetType: "ropsten", "main", "etc" 셋중 하나의 값을 입력해주시면됩니다.
         - ropsten: 이더리움의 Ropsten 테스트 네트워크입니다.
         - main: 이더리움의 메인 네트워크입니다.
         - etc: 사용자의 커스텀 네트워크입니다.
       - Main Infura Url, Ropsten Infura Url
         - Infura( https://www.infura.io )에 가입하여 각 네트워크의 rpc url을 입력해주세요.
     - 이더리움 테스트 데이터 설정

       ![스크린샷 2021-06-19 오후 8.14.03](https://user-images.githubusercontent.com/49587288/122644978-d3733b80-d152-11eb-80e0-1eaeee18d347.png)

       위에 이미지와 같이 Hierarchy 뷰에서 "IEthereumExample" 오브젝트를 선택하면 Inspector 뷰에 "IEthereumExample" 스크립트 컴포넌트에서 이더리움 테스트 데이터 설정값이 나옵니다. 아래의 옵션 설명을 참고하여 설정해주세요.

       **옵션**

       - PrivateKey: 내 이더리움 계정의 개인키입니다.
       - Address: 내 이더리움 계정의 주소입니다.
       - To Address: 상대 이더리움 계정의 주소입니다.
       - Token Amount: ERC-20 토큰 송금 테스트에 적용되는 ERC-20 토큰의 송금량입니다.
       - ERC721 Token Id: ERC-721 토큰 정보조회 및 전송 테스트등에 적용되는 ERC-721 토큰 ID 입니다.
       - ERC721 Token Index: ERC-721 토큰 정보조회 테스트 등에 적용되는 ERC-721 토큰의 인덱스입니다.
       - Block Number: 조회할 블럭의 넘버입니다.
       - Transaction Hash: 조회할 트랜잭션의 hash입니다.
       - ERC20 ContractAddress: ERC-20 토큰의 컨트랙트 어드레스입니다.
       - ERC721 ContractAddress: ERC-721 토큰의 컨트랙트 어드레스입니다.
   - 사슬 설정
     - 사슬 네트워크 설정

       ![스크린샷 2021-06-19 오후 9.29.23](https://user-images.githubusercontent.com/49587288/122645014-f998db80-d152-11eb-9b64-a80952f6fbd7.png)

       위에 이미지와 같이 Hierarchy 뷰에서 "ItemNetStatus" 오브젝트를 선택하면 Inspector 뷰에 "ItemNetStatus" 스크립트 컴포넌트에서 사슬 네트워크 설정값이 나옵니다. 아래의 옵션 설명을 참고하여 설정해주세요.

       **옵션**

       - NetType: "main", "etc" 둘중 하나의 값을 입력해주시면됩니다.
         - main: 사슬의 메인 네트워크입니다.
         - etc: 추가로 사슬 네트워크를 등록하고싶을때 사용하시면됩니다.
       - Main Url, Etc Url
         - ItemNet Explorer( https://explorer.itemverse.io/ )에 접속하여 각 네트워크의 url을 확인 하실 수 있습니다.
       - Version
         - 사용하고싶은 사슬의 버전을 입력하시면됩니다.
     - 사슬 테스트 데이터 설정

       ![스크린샷 2021-06-19 오후 9.29.29](https://user-images.githubusercontent.com/49587288/122645035-1a613100-d153-11eb-9821-c653e78b455e.png)

       위에 이미지와 같이 Hierarchy 뷰에서 "ItemNetExample" 오브젝트를 선택하면 Inspector 뷰에 "ItemNetExample" 스크립트 컴포넌트에서 사슬 테스트 데이터 설정값이 나옵니다. 아래의 옵션 설명을 참고하여 옵션을 설정해주세요.

       **옵션**

       - PrivateKey: 내 사슬 계정의 개인키입니다.
       - PublicKey: 내 사슬 계정의 공개키입니다.
       - Address: 내 사슬 계정의 주소입니다.
       - NFTUUID: ERC-721(NFT) 토큰의 아이디입니다.
       - Page: ListNFT 기능에 사용되는 옵션입니다. 출력 페이지를 지정합니다.
       - Count: ListNFT 기능에 사용되는 옵션입니다. 출력 개수를 지정합니다.
       - Sort: ListNFT 기능에 사용되는 옵션입니다. 정렬 타입을 지정합니다.
         - "1": 오름차순
         - "-1": 내림차순
       - NFT Class: ERC-721(NFT) 토큰 생성에 사용됩니다. 토큰의 그룹명입니다.
       - NFT Name: ERC-721(NFT) 토큰 생성에 사용됩니다. 토큰의 이름입니다.
       - NFT Thumbnail: ERC-721(NFT) 토큰 생성에 사용됩니다. 토큰의 썸네일입니다.
       - NFT Description: ERC-721(NFT) 토큰 생성에 사용됩니다. 토큰 설명입니다.
       - NFT Image: ERC-721(NFT) 토큰 생성에 사용됩니다. 토큰의 이미지입니다.

5. Game 탭에서 화면 크기를 1024 x 768 사이즈로 맞춰주고 실행합니다.

   ![스크린샷 2021-06-19 오후 9.56.51](https://user-images.githubusercontent.com/49587288/122645047-2baa3d80-d153-11eb-8233-a47a686a501e.png)

6. 버튼들을 클릭하여 Ethereum, Saseul 블록체인 기능들을 테스트해보세요. Change 버튼을 눌러서 테스트할 블록체인을 변경할 수 있으며 Copy 버튼을 눌러서 전체 결과를 복사할 수 있습니다.

   ![스크린샷 2021-06-19 오후 9.58.01](https://user-images.githubusercontent.com/49587288/122645058-3a90f000-d153-11eb-8717-1ecdb239ecfa.png)

7. 새 프로젝트에서 ItemNet Unity SDK를 적용할때는 ItemverseSDK/Prefab 경로의 "IEthereumStatus", "ItemNetStatus" Prefab을 새 프로젝트에 추가하고 Demo에 IEthereumExample.cs, ItemNetExample.cs를 참고해서 각 네트워크의 API들을 사용하시면됩니다.

   ![스크린샷 2021-07-22 오후 3 09 06](https://user-images.githubusercontent.com/49587288/126596533-a1fbd286-b456-457c-a0a7-b85c2d7760b3.png)

8. 이더리움 테스트에 유용한 사이트입니다.
   1. 테스트 이더리움 발급: https://faucet.ropsten.be/
   2. 테스트 이더리움 토큰 발급(ERC-721): https://faucet.itemverse.saseul.com/fauceterc721.html
   3. 테스트 이더리움 토큰 발급(ERC-20) : https://erc20faucet.com/
   4. 테스트 이더리움 익스플로러: https://ropsten.etherscan.io/

9. 사슬 테스트에 유용한 사이트입니다.
   1. 사슬 익스플로러: https://explorer.itemverse.io/
   2. 사슬 공식 사이트: https://saseul.com/#/
   3. 개발사 사이트: https://artifriends.com/
   4. SDK 공식 소개 사이트: https://itemverse.io/

------

### API

#### 이더리움

- **API:**  ItemverseSDK/Script/IEthereum/API/*

- **예제:**  ItemverseSDK/Demo/Script/IEthereumExample.cs

- **이더리움**

  - **GetBalance**

    - Description

      이더리움 잔고를 확인합니다.

    - Query Parameters

      | Field   | Type   | Description | Default Value |
      | ------- | ------ | ----------- | ------------- |
      | address | string | 계정 주소   |               |

    - Response

      | Field  | Type   | Description    | Default Value |
      | ------ | ------ | -------------- | ------------- |
      | result | string | 계정 잔고      |               |
      | status | bool   | 요청 성공 여부 |               |

  - **GetBlockByNumber**

    - Description

      인덱스로 블럭 데이터를 가져옵니다.

    - Query Parameters

      | Field       | Type          | Description | Default Value |
      | ----------- | ------------- | ----------- | ------------- |
      | blockNumber | HexBigInteger | 블럭 인덱스   |               |

    - Response

      | Field  | Type   | Description    | Default Value |
      | ------ | ------ | -------------- | ------------- |
      | result | string | 블럭 데이터    |               |
      | status | bool   | 요청 성공 여부 |               |

  - **GetLatestBlockNumber**

    - Description

      이더리움 네트워크에 쌓인 총 블럭 개수를 가져옵니다.

    - Response

      | Field  | Type   | Description    | Default Value |
      | ------ | ------ | -------------- | ------------- |
      | result | string | 총 블럭 개수      |               |
      | status | bool   | 요청 성공 여부 |               |

  - **GetTransactionByHash**

    - Description

      트랜잭션 해쉬로 트랜잭션 데이터를 가져옵니다.

    - Query Parameters

      | Field           | Type   | Description   | Default Value |
      | --------------- | ------ | ------------- | ------------- |
      | transactionHash | string | 트랜잭션 해쉬 |               |

    - Response

      | Field  | Type   | Description     | Default Value |
      | ------ | ------ | --------------- | ------------- |
      | result | string | 트랜잭션 데이터 |               |
      | status | bool   | 요청 성공 여부  |               |

  - **GetTransactionReceipt**

    - Description

      트랜잭션 해쉬로 트랜잭션 영수증 데이터를 가져옵니다.

    - Query Parameters

      | Field           | Type   | Description   | Default Value |
      | --------------- | ------ | ------------- | ------------- |
      | transactionHash | string | 트랜잭션 해쉬 |               |

    - Response

      | Field  | Type   | Description            | Default Value |
      | ------ | ------ | ---------------------- | ------------- |
      | result | string | 트랜잭션 영수증 데이터 |               |
      | status | bool   | 요청 성공 여부         |               |

  - **Transfer**

    - Description

      이더리움을 송금합니다.

    - Query Parameters

      | Field      | Type    | Description | Default Value |
      | ---------- | ------- | ----------- | ------------- |
      | privateKey | string  | 계정 개인키 |               |
      | toAddress  | string  | 수신자 주소 |               |
      | amount     | decimal | 이더리움 송금량(eth 단위)      |               |

    - Response

      | Field  | Type   | Description    | Default Value |
      | ------ | ------ | -------------- | ------------- |
      | result | string | 송금 결과      |               |
      | status | bool   | 요청 성공 여부 |               |
      
- **ERC20**
  
  - **ERC20_GetBalance**
  
    - Description
  
      ERC-20 토큰 잔고를 확인합니다.
  
    - Query Parameters
  
      | Field           | Type   | Description          | Default Value |
      | --------------- | ------ | -------------------- | ------------- |
      | address         | string | 계정 주소            |               |
      | contractAddress | string | ERC-20 컨트랙트 주소 |               |
  
    - Response
  
      | Field  | Type   | Description           | Default Value |
      | ------ | ------ | --------------------- | ------------- |
      | result | string | ERC-20 토큰 잔고 |               |
      | status | bool   | 요청 성공 여부        |               |
  
  - **ERC20_Name**
  
    - Description
  
      ERC-20 토큰의 이름을 확인합니다.
  
    - Query Parameters
  
      | Field           | Type   | Description          | Default Value |
      | --------------- | ------ | -------------------- | ------------- |
      | contractAddress | string | ERC-20 컨트랙트 주소 |               |
  
    - Response
  
      | Field  | Type   | Description      | Default Value |
      | ------ | ------ | ---------------- | ------------- |
      | result | string | ERC-20 토큰 이름 |               |
      | status | bool   | 요청 성공 여부   |               |
  
  - **ERC20_Symbol**
  
    - Description
  
      ERC-20 토큰의 심볼을 확인합니다.
  
    - Query Parameters
  
      | Field           | Type   | Description          | Default Value |
      | --------------- | ------ | -------------------- | ------------- |
      | contractAddress | string | ERC-20 컨트랙트 주소 |               |
  
    - Response
  
      | Field  | Type   | Description      | Default Value |
      | ------ | ------ | ---------------- | ------------- |
      | result | string | ERC-20 토큰 심볼 |               |
      | status | bool   | 요청 성공 여부   |               |
  
  - **ERC20_TotalSupply**
  
    - Description
  
      ERC-20 토큰의 총 발행량을 확인합니다.
  
    - Query Parameters
  
      | Field           | Type   | Description          | Default Value |
      | --------------- | ------ | -------------------- | ------------- |
      | contractAddress | string | ERC-20 컨트랙트 주소 |               |
  
    - Response
  
      | Field  | Type   | Description           | Default Value |
      | ------ | ------ | --------------------- | ------------- |
      | result | string | ERC-20 토큰 총 발행량 |               |
      | status | bool   | 요청 성공 여부        |               |
  
  - **ERC20_Transfer**
  
    - Description
  
      ERC-20 토큰을 송금합니다.
  
    - Query Parameters
  
      | Field           | Type       | Description          | Default Value |
      | --------------- | ---------- | -------------------- | ------------- |
      | privateKey      | string     | 발신자 개인키          |               |
      | toAddress       | string     | 수신자 주소          |               |
      | tokenAmount     | BigInteger | ERC-20 토큰 송금량   |               |
      | contractAddress | string     | ERC-20 컨트랙트 주소 |               |
  
    - Response
  
      | Field  | Type   | Description           | Default Value |
      | ------ | ------ | --------------------- | ------------- |
      | result | string | ERC-20 토큰 송금 결과 |               |
      | status | bool   | 요청 성공 여부        |               |
  
- **ERC721**
  
  - **ERC721_GetBalance**
  
    - Description
  
      ERC-721 토큰 잔고를 확인합니다.
  
    - Query Parameters
  
      | Field           | Type   | Description           | Default Value |
      | --------------- | ------ | --------------------- | ------------- |
      | address         | string | 계정 주소             |               |
      | contractAddress | string | ERC-721 컨트랙트 주소 |               |
  
    - Response
  
      | Field  | Type   | Description       | Default Value |
      | ------ | ------ | ----------------- | ------------- |
      | result | string | ERC-721 토큰 잔고 |               |
      | status | bool   | 요청 성공 여부    |               |
  
  - **ERC721_Name**
  
    - Description
  
      ERC-721 토큰 이름을 확인합니다.
  
    - Query Parameters
  
      | Field           | Type   | Description           | Default Value |
      | --------------- | ------ | --------------------- | ------------- |
      | contractAddress | string | ERC-721 컨트랙트 주소 |               |
  
    - Response
  
      | Field  | Type   | Description       | Default Value |
      | ------ | ------ | ----------------- | ------------- |
      | result | string | ERC-721 토큰 이름 |               |
      | status | bool   | 요청 성공 여부    |               |
  
  - **ERC721_OwnerOf**
  
    - Description
  
      ERC-721 토큰 Id로 소유자를 검색합니다.
  
    - Query Parameters
  
      | Field           | Type       | Description           | Default Value |
      | --------------- | ---------- | --------------------- | ------------- |
      | tokenId         | BigInteger | ERC-721 토큰 Id       |               |
      | contractAddress | string     | ERC-721 컨트랙트 주소 |               |
  
    - Response
  
      | Field  | Type   | Description         | Default Value |
      | ------ | ------ | ------------------- | ------------- |
      | result | string | ERC-721 토큰 소유자 |               |
      | status | bool   | 요청 성공 여부      |               |
  
  - **ERC721_Symbol**
  
    - Description
  
      ERC-721 토큰 심볼을 확인합니다.
  
    - Query Parameters
  
      | Field           | Type   | Description           | Default Value |
      | --------------- | ------ | --------------------- | ------------- |
      | contractAddress | string | ERC-721 컨트랙트 주소 |               |
  
    - Response
  
      | Field  | Type   | Description       | Default Value |
      | ------ | ------ | ----------------- | ------------- |
      | result | string | ERC-721 토큰 심볼 |               |
      | status | bool   | 요청 성공 여부    |               |
  
  - **ERC721_TokenOfOwnerByIndex**
  
    - Description
  
      인덱스로 소유자가 소유한 ERC-721 토큰 Id를 확인합니다.
  
    - Query Parameters
  
      | Field           | Type   | Description           | Default Value |
      | --------------- | ------ | --------------------- | ------------- |
      | address         | string | 계정 주소             |               |
      | index           | string | ERC-721 토큰 인덱스   |               |
      | contractAddress | string | ERC-721 컨트랙트 주소 |               |
  
    - Response
  
      | Field  | Type   | Description     | Default Value |
      | ------ | ------ | --------------- | ------------- |
      | result | string | ERC-721 토큰 Id |               |
      | status | bool   | 요청 성공 여부  |               |
  
  - **ERC721_TokenURI**
  
    - Description
  
      ERC-721 토큰 ID로 ERC-721 토큰의 메타데이터 URI를 확인합니다.
  
    - Query Parameters
  
      | Field           | Type       | Description           | Default Value |
      | --------------- | ---------- | --------------------- | ------------- |
      | tokenId         | BigInteger | ERC-721 토큰 Id       |               |
      | contractAddress | string     | ERC-721 컨트랙트 주소 |               |
  
    - Response
  
      | Field  | Type   | Description     | Default Value |
      | ------ | ------ | --------------- | ------------- |
      | result | string | ERC-721 토큰 메타데이터 URI |               |
      | status | bool   | 요청 성공 여부  |               |
  
  - **ERC721_TotalSupply**
  
    - Description
  
      ERC-721 토큰의 총 발행량을 확인합니다.
  
    - Query Parameters
  
      | Field           | Type   | Description           | Default Value |
      | --------------- | ------ | --------------------- | ------------- |
      | contractAddress | string | ERC-721 컨트랙트 주소 |               |
  
    - Response
  
      | Field  | Type   | Description            | Default Value |
      | ------ | ------ | ---------------------- | ------------- |
      | result | string | ERC-721 토큰 총 발행량 |               |
      | status | bool   | 요청 성공 여부         |               |
  
  - **ERC721_Transfer**
  
    - Description
  
      ERC-721 토큰을 송금합니다.
  
    - Query Parameters
  
      | Field           | Type       | Description           | Default Value |
      | --------------- | ---------- | --------------------- | ------------- |
      | privateKey      | string     | 발신자 개인키           |               |
      | toAddress       | string     | 수신자 주소           |               |
      | tokenId         | BigInteger | ERC-721 토큰 ID       |               |
      | contractAddress | string     | ERC-721 컨트랙트 주소 |               |
  
    - Response
  
      | Field  | Type   | Description            | Default Value |
      | ------ | ------ | ---------------------- | ------------- |
      | result | string | ERC-721 토큰 송금 결과 |               |
      | status | bool   | 요청 성공 여부         |               |

#### 사슬

 - **API:** ItemverseSDK/Script/ItemNet/API/*

 - **예제:** ItemverseSDK/Demo/Script/ItemNetExample.cs

 - **API 문서:** https://docs.itemverse.io

 - **<u>주의:</u>** 아래의 API를 제외한 ItemverseSDK/Script/ItemNet/API/ExampleAPI 폴더 안에 API 스크립트들은 임시로 추가된 API입니다. 임시 API는 차후 업데이트에 따라 변경이 될 수 있습니다.

 - **SendRequest**

   - Description

      사슬 API를 호출합니다.

   - Query Parameters

     | Field       | Type   | Description     | Default Value |
     | ----------- | ------ | --------------- | ------------- |
     | requestData | string | API 호출 데이터 |               |

   - Response

     | Field  | Type   | Description    | Default Value |
     | ------ | ------ | -------------- | ------------- |
     | result | string | API 호출 결과  |               |
     | status | bool   | 요청 성공 여부 |               |

 - **SendTransaction**

   - Description

      사슬에 트랜잭션을 전송합니다.

   - Query Parameters

     | Field           | Type   | Description              | Default Value |
     | --------------- | ------ | ------------------------ | ------------- |
     | privateKey      | string | 트랜잭션을 사인할 개인키 |               |
     | transactionData | string | 트랜잭션 데이터          |               |

   - Response

     | Field  | Type   | Description        | Default Value |
     | ------ | ------ | ------------------ | ------------- |
     | result | string | 트랜잭션 전송 결과 |               |
     | status | bool   | 요청 성공 여부     |               |

 - **SendRawTransaction**

   - Description

      사슬에 사인된 트랜잭션을 전송합니다.

   - Query Parameters

     | Field       | Type   | Description     | Default Value |
     | ----------- | ------ | --------------- | ------------- |
     | transaction | string | 사인된 트랜잭션 |               |
     | thash       | string | 사인된 트랜잭션의 해쉬   |               |
     | publicKey   | string | 계정 공유키          |               |
     | signature   | string | 사인 데이터     |               |

   - Response

     | Field  | Type   | Description             | Default Value |
     | ------ | ------ | ----------------------- | ------------- |
     | result | string | 트랜잭션 전송 결과 |               |
     | status | bool   | 요청 성공 여부          |               |

------

### 
