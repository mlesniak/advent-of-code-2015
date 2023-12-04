#include <iostream>
#include <iomanip>
#include <sstream>
#include <openssl/md5.h>

using namespace std;

std::string md5(const std::string &str){
  unsigned char hash[MD5_DIGEST_LENGTH];

  MD5_CTX md5;
  MD5_Init(&md5);
  MD5_Update(&md5, str.c_str(), str.size());
  MD5_Final(hash, &md5);

  std::stringstream ss;

  for(int i = 0; i < MD5_DIGEST_LENGTH; i++){
    ss << std::hex << std::setw(2) << std::setfill('0') << static_cast<int>( hash[i] );
  }
  return ss.str();
}

int main() {
    string input = "bgvyzdsv";
    std::cout << "Example 1 "<< md5("abcdef609043") << std::endl;
    std::cout << "Example 2 "<< md5("pqrstuv1048970") << std::endl;

    int i = 0;
    while (true)
    {
        auto theHash = md5("bgvyzdsv" + to_string(i));
        if (theHash.substr(0, 5) == "00000")
        {
            cout << i << " for " << theHash << endl;
        }
        // for part two
        if (theHash.substr(0, 6) == "000000")
        {
            cout << "Second "<< i << " for " << theHash << endl;
            break;
        }        

        i++;
    }
    

    
    


}