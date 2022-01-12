# Checkout Kata

## Introduction

This Checkout Kata is based upon the information gleaned from 
[codekata.com](http://codekata.com/kata/kata09-back-to-the-checkout/).

## Premise

A Customer with a basket of items arrives at a checkout station. They 
scan each item of their basket in turn and are told the total price for 
their shopping.

The price of an item may depend upon the quantity of the item in the 
Customer's basket.

## Assumption

1. There is no need for any persistence mechanism
1. The checkout can be a stateful service
1. The pricing mechanism (i.e. what calculates price) does not need to be implemented
1. There is no need to remove items once checked out
1. There is no need to adjust quantities of an item downwards once checked out
1. There are no other forms of discounting or promotions beyond quantity break pricing applied to a SKU
