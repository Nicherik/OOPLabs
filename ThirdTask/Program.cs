using ThirdTask.Classes;

Tree main = new Tree("main");
Tree tree1 = new Tree("tree1");
Tree tree2 = new Tree("tree2");
Tree tree3 = new Tree("tree3");


main.AddStruct(tree1);
main.AddStruct(tree2);
main.AddStruct(tree3);

Tree otherTree1 = new Tree("otherTree1");
Tree otherTree2 = new Tree("otherTree2");


main.AddStruct(otherTree1);
main.AddStruct(otherTree2);

Tree otherTreeChild1 = new Tree("otherTreeChild1");
Tree otherTreeChild2 = new Tree("otherTreeChild2");

otherTree1.AddStruct(otherTreeChild1);
otherTree2.AddStruct(otherTreeChild2);

main.DisplayValues();