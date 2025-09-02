using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGNPATTERNPROJECT.ITERATOR
{
    public class ProjectCompositeIterator : IEnumerator<IProjectElement>
    {
        private Stack<IEnumerator<IProjectElement>> stack;
        //TODO: Use a linked-list based stack
        private IProjectElement current;

        public ProjectCompositeIterator(IProjectElement root)
        {
            stack = new Stack<IEnumerator<IProjectElement>>();
            // Start with root's children
            stack.Push(root.CreateIterator());
        }

        public IProjectElement Current => current;
        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            while (stack.Count > 0)
            {
                IEnumerator<IProjectElement> iterator = stack.Peek();

                if (!iterator.MoveNext())
                {
                    stack.Pop(); // This iterator is exhausted
                    continue;
                }
                //This points to current element iterator points to in the collection.
                current = iterator.Current;

                // This iterates over the current element's collection.
                var childIterator = current.CreateIterator();
                //TODO: add this logic after:
                //if (childIterator != null && childIterator.MoveNext())
                if (childIterator != null)
                {
                    stack.Push(childIterator);
                }

                return true;
            }
            return false; // No more elements
        }

        public void Reset()
        {
            throw new NotSupportedException("Reset not supported");
        }

        public void Dispose()
        {
            while (stack.Count > 0)
            {
                stack.Pop()?.Dispose();
            }
        }
    }

}
