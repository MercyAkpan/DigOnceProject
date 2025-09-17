using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternProject.Interfaces;

namespace DesignPatternProject.Iterator
{
    public class ProjectCompositeIterator : IEnumerator<IProjectElement>
    {
        private Stack<IEnumerator<IProjectElement>> stack;
        //TODO: Use a linked-list based stack
        private IProjectElement current;

        public ProjectCompositeIterator(IProjectElement root)
        {
            // Stack created to store iterators over collections in each component 
            // whether ProjectPhase, ProjectTask, ISPElement.
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
                // Iterator always points to item at the top of the stack.
                IEnumerator<IProjectElement> iterator = stack.Peek();
                // MoveNext() will be false when called by a ProjectTask iterator.
                // Else MoveNext() will move to next element in collection and return true.
                if (!iterator.MoveNext())
                {
                // This iterator is exhausted
                    stack.Pop(); 
                    continue;
                }
                //This points to current element the iterator points to in the collection.
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
