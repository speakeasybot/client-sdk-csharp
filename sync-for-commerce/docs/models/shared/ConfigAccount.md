# ConfigAccount

G/L account object for configuration.


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `accountOptions`                                            | List<[AccountOption](../../models/shared/AccountOption.md)> | :heavy_minus_sign:                                          | Object containing account options.                          |
| `descriptionText`                                           | *string*                                                    | :heavy_minus_sign:                                          | Descriprtive text for sales configuration section.          |
| `labelText`                                                 | *string*                                                    | :heavy_minus_sign:                                          | Label text for sales configuration section.                 |
| `required`                                                  | *bool*                                                      | :heavy_minus_sign:                                          | Required section to be configured for sync.                 |
| `selectedAccountId`                                         | *string*                                                    | :heavy_minus_sign:                                          | Selected account id from the list of available accounts.    |