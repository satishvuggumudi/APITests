Feature: ApiAcceptenceTests
	In order to test t
	As a math idiot
	I want to be told the sum of two numbers
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario Outline: Get users by user Id
	When I request Get an user resource by valid <UserId>
	Then I receive valid HTTP Success response status code
	And Response Body is non-empty
Examples:
	| UserId |
	| 1      |
	| 3      |
	| 10     |

Scenario Outline: Get user posts by post Id
	When I request Get an user posts resource by valid <PostId>
	Then I receive valid HTTP Success response status code
	And Response Body is non-empty
Examples:
	| PostId |
	| 1      |
	| 30     |
	| 99     |

Scenario Outline: Get user post Comments by comments Id
	When I request Get an user post Comments resource by valid <CommentsId> 
	Then I receive valid HTTP Success response status code
	And Response Body is non-empty
Examples:
	| CommentsId |
	| 1          |
	| 25         |
	| 100        |
	| 499        |

Scenario Outline: Get user todos by todos Id
	When I request Get an user todos resource by valid <ToDosId>
	Then I receive valid HTTP Success response status code
	And Response Body is non-empty
Examples:
	| ToDosId |
	| 1       |
	| 30      |
	| 200     |

Scenario Outline: Get user albums by album Id
	When I request Get an user album resource by valid <AlbumId>
	Then I receive valid HTTP Success response status code
	And Response Body is non-empty
Examples:
	| AlbumId |
	| 11      |
	| 33      |
	| 100     |

Scenario Outline: Get user album photos by photo Id
	When I request Get an user album photos resource by valid <PhotoId>
	Then I receive valid HTTP Success response status code
	And Response Body is non-empty
Examples:
	| PhotoId |
	| 1       |
	| 30      |
	| 105     |
	| 999     |
	| 1001    |
	| 5000    |

Scenario Outline: Get List of Comments for a post 
	When I request Get list of comments assosiated to a post by <PostId>
	Then I receive valid HTTP Success response status code
	And Response Body is non-empty
Examples:
	| PostId |
	| 12     |
	| 30     |
	| 100    |

Scenario Outline: Get List of photos for a album 
	When I request Get list of photos assosiated to a album by <AlbumId>
	Then I receive valid HTTP Success response status code
	And Response Body is non-empty
Examples:
	| AlbumId |
	| 11      |
	| 33      |
	| 100     |

Scenario Outline: Get List of albums for a user 
	When I request Get list of albums assosiated to a user by <UserId>
	Then I receive valid HTTP Success response status code
	And Response Body is non-empty
Examples:
	| UserId |
	| 1      |
	| 3      |
	| 10     |

Scenario Outline: Get List of todos for a user 
	When I request Get list of todos assosiated to a user by <UserId>
	Then I receive valid HTTP Success response status code
	And Response Body is non-empty
Examples:
	| UserId |
	| 1      |
	| 3      |
	| 10     |

Scenario Outline: Get List of posts for a user 
	When I request Get list of posts assosiated to a user by <UserId>
	Then I receive valid HTTP Success response status code
	And Response Body is non-empty
Examples:
	| UserId |
	| 1      |
	| 3      |
	| 10     |

#InValid Requests  - Out of range 
Scenario Outline: Get users by invalid user Id
	When I request Get an user resource by valid <UserId>
	Then I receive failure response code
Examples:
	| UserId |
	| 0      |
	| 100    |

Scenario Outline: Get user posts by invalid post Id
	When I request Get an user posts resource by valid <PostId>
	Then I receive failure response code
Examples:
	| PostId |
	| 0      |
	| 101    |

Scenario Outline: Get user post Comments by invalid comments Id
	When I request Get an user post Comments resource by valid <CommentsId> 
	Then I receive failure response code
Examples:
	| CommentsId |
	| 0          |
	| 1000       |

Scenario Outline: Get user todos by invalid todos Id
	When I request Get an user todos resource by valid <ToDosId>
	Then I receive failure response code
Examples:
	| ToDosId |
	| 0       |
	| 300     |

Scenario Outline: Get user albums by invalid album Id
	When I request Get an user album resource by valid <AlbumId>
	Then I receive failure response code
Examples:
	| AlbumId |
	| 0       |
	| 110     |

Scenario Outline: Get user album photos by invalid photo Id
	When I request Get an user album photos resource by valid <PhotoId>
	Then I receive failure response code
Examples:
	| PhotoId |
	| 0       |
	| 50010   |

Scenario Outline: Invaild - Get List of Comments for a post 
	When I request Get list of comments assosiated to a post by <PostId>
	Then I receive failure response code
Examples:
	| PostId |
	| 0      |
	| 10000  |

Scenario Outline:: Invaild - Get List of photos for a album 
	When I request Get list of photos assosiated to a album by <AlbumId>
	Then I receive failure response code
Examples:
	| AlbumId |
	| 0       |
	| 200     |

Scenario Outline: Invaild - Get List of albums for a user 
	When I request Get list of albums assosiated to a user by <UserId>
	Then I receive failure response code
Examples:
	| UserId |
	| 0      |
	| 100    |

Scenario Outline: Invaild - Get List of todos for a user 
	When I request Get list of todos assosiated to a user by <UserId>
	Then I receive failure response code
Examples:
	| UserId |
	| 0      |
	| 100    |

Scenario Outline: Invaild - Get List of posts for a user 
	When I request Get list of posts assosiated to a user by <UserId>
	Then I receive failure response code
Examples:
	| UserId |
	| 0      |
	| 100    |

#Create new Posts
Scenario Outline: Creatre a posts for a user
	When I create apost for a user <UserId>
	Then I receive valid HTTP Success response Created
	And Response Body is non-empty
Examples:
	| UserId |
	| 1      |
	| 3      |
	| 10     |