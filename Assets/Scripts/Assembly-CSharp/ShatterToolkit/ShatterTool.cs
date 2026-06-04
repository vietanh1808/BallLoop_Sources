using System;
using System.Collections.Generic;
using UnityEngine;

namespace ShatterToolkit
{
	[RequireComponent(typeof(MeshFilter))]
	public class ShatterTool : MonoBehaviour
	{
		[SerializeField]
		protected int generation;

		[SerializeField]
		protected int generationLimit;

		[SerializeField]
		protected int cuts;

		[SerializeField]
		protected bool fillCut;

		[SerializeField]
		protected bool sendPreSplitMessage;

		[SerializeField]
		protected bool sendPostSplitMessage;

		[SerializeField]
		protected HullType internalHullType;

		protected bool isIntact;

		protected IHull hull;

		protected Vector3 center;

		public static Action ForceDestryAc;

		public int Generation
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int GenerationLimit
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Cuts
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool FillCut
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool SendPreSplitMessage
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool SendPostSplitMessage
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public HullType InternalHullType
		{
			get
			{
				return default(HullType);
			}
			set
			{
			}
		}

		public bool IsFirstGeneration => false;

		public bool IsLastGeneration => false;

		public Vector3 Center => default(Vector3);

		protected void CalculateCenter()
		{
		}

		public void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void Shatter(Vector3 point)
		{
		}

		public void Split(Plane[] planes)
		{
		}

		protected void ConvertPlanesToLocalspace(Plane[] planes, out Vector3[] points, out Vector3[] normals)
		{
			points = null;
			normals = null;
		}

		protected void CreateNewHulls(UvMapper uvMapper, ColorMapper colorMapper, Vector3[] points, Vector3[] normals, out IList<IHull> newHulls)
		{
			newHulls = null;
		}

		protected void CreateNewGameObjects(IList<IHull> newHulls, out GameObject[] newGameObjects)
		{
			newGameObjects = null;
		}

		private void OnForceDestroyEvent()
		{
		}
	}
}
