# GetDataIntegritySummariesRequest


## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    | Example                                                                        |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `companyId`                                                                    | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            | 8a210b68-6988-11ed-a1eb-0242ac120002                                           |
| `dataType`                                                                     | [DataIntegrityDataType](../../Models/Shared/DataIntegrityDataType.md)          | :heavy_check_mark:                                                             | A key for a Codat data type.                                                   | banking-accounts                                                               |
| `query`                                                                        | *string*                                                                       | :heavy_minus_sign:                                                             | Codat query string. [Read more](https://docs.codat.io/using-the-api/querying). |                                                                                |