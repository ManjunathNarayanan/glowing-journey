//Smart pointers try to prevent memory leaks by making the resource deallocation automatic: 
//when the pointer to an object (or the last in a series of pointers) is destroyed, 
//for example because it goes out of scope, the pointed object is destroyed too.

#include <iostream>
#include <memory>
using namespace std;

class entity
{
public:
	entity()
	{
		cout << "Entity created" << endl;
	}

	~entity()
	{
		cout << "Entity destroyed" << endl;
	}
};

int main()
{
	//Unique pointer is destroyed when it goes out of this scope!
	{
		unique_ptr<entity> uniqEntity = make_unique<entity>();
	}

	//Shared pointer works by reference counting and memory is deleted only when ref reaches 0
	shared_ptr<entity> sharedEntity1;
	{
		shared_ptr<entity> sharedEntity = make_shared<entity>();

		//now ref is 2
		sharedEntity1 = sharedEntity;
	}//now ref is 1

	//Weak pointer doesnot increase ref count so ref count remains 1
	weak_ptr<entity> weakEntity = sharedEntity1;
}
