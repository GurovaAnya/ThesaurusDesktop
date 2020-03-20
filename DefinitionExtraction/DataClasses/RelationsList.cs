using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinitionExtraction
{
    public class RelationsList : IEnumerable<KeyValuePair<Relation, List<Termin>>>
    {
        SortedList<Relation, List<Termin>> relations;
        public int Count{ get; private set; }

        public RelationsList()
        {
            relations = new SortedList<Relation, List<Termin>>();
        }

        public void AddRelation(Relation relation, Termin descriptor)
        {
            if (relations.ContainsKey(relation))
            {
                relations[relation].Add(descriptor);
            }
            else
            {
                List<Termin> list = new List<Termin>();
                list.Add(descriptor);
                relations.Add(relation, list);
                Count++;
            }
        }

        public IEnumerator<KeyValuePair<Relation, List<Termin>>> GetEnumerator()
        {
            return new RelationsEnum(relations);     
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }

    public class RelationsEnum:IEnumerator<KeyValuePair<Relation, List<Termin>>>
    {
        public SortedList<Relation, List<Termin>> relations;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public RelationsEnum(SortedList<Relation, List<Termin>> list)
        {
            relations = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < relations.Count);
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {

        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public KeyValuePair<Relation, List<Termin>> Current
        {
            get
            {
                try
                {
                    return relations.ElementAt(position);
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

    }
}
