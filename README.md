# Spyduh: A Social Network for Spies

## Get Started:

```javascript
 $ git clone git@github.com:nss-evening-cohort-16/targaryen-spyduh.git
 $ cd targaryen-spyduh
```

## About the Users
* This social network allows spies to create SpyDuh accounts with their (im)personal details, including why they became a spy, as well as to socialize and find friends with similar skills. Using Postman, the spy can make calls to the API to make specific requests depending on their needs.


## Features: 
* Spies can join the social network, listing their codename, skills/services, origin story, and days until undercover assignment is over.
* Spies can see their friends/enemies and friends of their friends. 
* Spies can search by skill, days left in undercover assignment, and see all spies in the network.
* Spies can also make updates to their profile or delete it entirely.

## Code Snippet:

```c#
internal object GetFriendsOfFriends(string name, SpyRelationship spyRelationship)
  {
    var matchingSpy = _spies.FirstOrDefault(s => s.CodeName == name);
    var friends = _spies.Where(matchingSpy => matchingSpy.Relationship == spyRelationship);
    var friendsOrEnemies = friends.Where(s => s.CodeName != name);
    return friendsOrEnemies;
  }
```

## Planning:

<img width="454" alt="2022-02-05 (1)" src="https://user-images.githubusercontent.com/86667443/154809270-86291ee5-bb1b-47f2-8a97-b1e9b70936fa.jpg">

### Contributors: [Mary Beth Hunter](https://github.com/marybethhunter), [Albert Chittaphong](https://github.com/albertchitta), [Gabriel Smith](https://github.com/Gabrielsmith1998), [Klay Thacker](https://github.com/KlayTT)
