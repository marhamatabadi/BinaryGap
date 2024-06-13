# Welcome to BinaryGap!


This solution aims to address the **BinaryGap** problem. **What exactly is the BinaryGap?** In the binary representation of a positive integer N, a binary gap refers to any consecutive sequence of zeros that is bordered by ones at both ends.

For instance, consider the number 9 with a binary representation of 1**00**1; it possesses a binary gap of length 2. Similarly, the number 529, represented in binary as 1**0000**10001, harbors two binary gaps: one spanning 4 digits and another spanning 3. On the other hand, number 20, in binary 1**0**100, contains a single binary gap of length 1. Conversely, number 15, represented as 1111 in binary, lacks any binary gaps. Likewise, number 32, depicted as 100000 in binary, also lacks binary gaps.

The function Solution, when given a positive integer N, outputs the length of its longest binary gap. In instances where N doesn’t contain a binary gap, the function returns 0.

For example, if N = 1041, the function would yield 5 since N's binary representation is 1**00000**10001, indicating its longest binary gap spans 5 digits. Conversely, if N = 32, the function would return 0 because N's binary representation is '100000', indicating the absence of binary gaps.

>- **N falls within the integer range of [1…2,147,483,647].**


[Linkedin](https://www.linkedin.com/in/marhamatabadi)