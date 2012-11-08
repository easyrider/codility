using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CrackingCodingInterview.Chapter3
{
    [Reference(
        Page = 52
        , Number = "3.4"
        , Description = "Classic Twoers of Hanoi. " +
                        "Write program to move the disks from the first rod to the last using Stacks")]
    public class HanoiTower
    {

        private readonly Stack<int> _disks = new Stack<int>();

        public HanoiTower(string name)
        {
            if (name == null) throw new ArgumentNullException("name");
            Name = name;
        }

        public string Name { get; private set; }

        public void MoveDisks(int disk, HanoiTower destination, HanoiTower buffer)
        {
            if (disk <= 0) return;
            MoveDisks(disk - 1, buffer, destination);
            MoveTopTo(destination);
            buffer.MoveDisks(disk - 1, destination, this);
        }

        public int[] ToArray()
        {
            return _disks.ToArray();
        }

        private void MoveTopTo(HanoiTower destination)
        {
            int pop = _disks.Pop();
            destination.Add(pop);
            Trace.TraceInformation("Move disk {0} from {1} to {2}", pop, Name, destination.Name);
        }

        public void Add(int pop)
        {
            if ((_disks.Count > 0) && (_disks.Peek() <= pop))
                throw new ArgumentException("pop", "pop");

            _disks.Push(pop);
        }
    }
}