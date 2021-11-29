// SPDX-License-Identifier: MIT
pragma solidity ^0.8.2;

import "@openzeppelin/contracts@4.3.3/token/ERC20/ERC20.sol";
import "@openzeppelin/contracts@4.3.3/access/Ownable.sol";

contract MyCoolToken is ERC20, Ownable {
    constructor() ERC20("MyCoolToken", "MCK") {
        _mint(msg.sender, 10000000 * 10 ** decimals());
    }

    function mint(address to, uint256 amount) public onlyOwner {
        _mint(to, amount);
    }
}