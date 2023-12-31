// Decompiled with JetBrains decompiler
// Type: ProjectM.NativeMinHeap`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  public struct NativeMinHeap<T>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TreeData;
    private static readonly System.IntPtr NativeFieldInfoPtr__Heap;
    private static readonly System.IntPtr NativeFieldInfoPtr__Elements;
    private static readonly System.IntPtr NativeFieldInfoPtr__FreeIndices;
    private static readonly System.IntPtr NativeFieldInfoPtr__AllocatorLabel;
    private static readonly System.IntPtr NativeFieldInfoPtr__Capacity_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Capacity_Private_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryPopNewDataIndex_Private_Boolean_byref_TreeData_T_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PushFreeDataIndex_Private_Void_byref_TreeData_T_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Pop_Public_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HeapifyTopToBottom_Private_Void_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Push_Public_Void_T_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HeapifyBottomToTop_Private_Void_Int32_0;
    public unsafe void* _TreeData;
    public NativeArray<NativeMinHeap<T>.Element> _Heap;
    public NativeArray<T> _Elements;
    public NativeArray<int> _FreeIndices;
    public Allocator _AllocatorLabel;
    public int _Capacity_k__BackingField;

    public unsafe int Capacity
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NativeMinHeap<T>.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(7), CachedScanResults(RefRangeStart = 70456, RefRangeEnd = 70463, XrefRangeStart = 70456, XrefRangeEnd = 70463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NativeMinHeap<T>.NativeMethodInfoPtr_set_Capacity_Private_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int Length
    {
      [CallerCount(11), CachedScanResults(RefRangeStart = 746980, RefRangeEnd = 746991, XrefRangeStart = 746978, XrefRangeEnd = 746980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NativeMinHeap<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 747006, RefRangeEnd = 747010, XrefRangeStart = 746991, XrefRangeEnd = 747006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeMinHeap(int capacity, Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &capacity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NativeMinHeap<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool TryPopNewDataIndex(ref NativeMinHeap<T>.TreeData treeData, out int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref treeData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NativeMinHeap<T>.NativeMethodInfoPtr_TryPopNewDataIndex_Private_Boolean_byref_TreeData_T_byref_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void PushFreeDataIndex(ref NativeMinHeap<T>.TreeData treeData, int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref treeData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NativeMinHeap<T>.NativeMethodInfoPtr_PushFreeDataIndex_Private_Void_byref_TreeData_T_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 747019, RefRangeEnd = 747020, XrefRangeStart = 747010, XrefRangeEnd = 747019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NativeMinHeap<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 747026, RefRangeEnd = 747028, XrefRangeStart = 747020, XrefRangeEnd = 747026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe T Pop()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(NativeMinHeap<T>.NativeMethodInfoPtr_Pop_Public_T_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747028, XrefRangeEnd = 747030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HeapifyTopToBottom(int sizeOfTree, int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &sizeOfTree;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NativeMinHeap<T>.NativeMethodInfoPtr_HeapifyTopToBottom_Private_Void_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 747037, RefRangeEnd = 747039, XrefRangeStart = 747030, XrefRangeEnd = 747037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Push(T value, float weight)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *numPtr2 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &weight;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NativeMinHeap<T>.NativeMethodInfoPtr_Push_Public_Void_T_Single_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747039, XrefRangeEnd = 747040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HeapifyBottomToTop(int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NativeMinHeap<T>.NativeMethodInfoPtr_HeapifyBottomToTop_Private_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NativeMinHeap()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", "NativeMinHeap`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr);
      NativeMinHeap<T>.NativeFieldInfoPtr__TreeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, nameof (_TreeData));
      NativeMinHeap<T>.NativeFieldInfoPtr__Heap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, nameof (_Heap));
      NativeMinHeap<T>.NativeFieldInfoPtr__Elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, nameof (_Elements));
      NativeMinHeap<T>.NativeFieldInfoPtr__FreeIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, nameof (_FreeIndices));
      NativeMinHeap<T>.NativeFieldInfoPtr__AllocatorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, nameof (_AllocatorLabel));
      NativeMinHeap<T>.NativeFieldInfoPtr__Capacity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, "<Capacity>k__BackingField");
      NativeMinHeap<T>.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, 100665765);
      NativeMinHeap<T>.NativeMethodInfoPtr_set_Capacity_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, 100665766);
      NativeMinHeap<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, 100665767);
      NativeMinHeap<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, 100665768);
      NativeMinHeap<T>.NativeMethodInfoPtr_TryPopNewDataIndex_Private_Boolean_byref_TreeData_T_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, 100665769);
      NativeMinHeap<T>.NativeMethodInfoPtr_PushFreeDataIndex_Private_Void_byref_TreeData_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, 100665770);
      NativeMinHeap<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, 100665771);
      NativeMinHeap<T>.NativeMethodInfoPtr_Pop_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, 100665772);
      NativeMinHeap<T>.NativeMethodInfoPtr_HeapifyTopToBottom_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, 100665773);
      NativeMinHeap<T>.NativeMethodInfoPtr_Push_Public_Void_T_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, 100665774);
      NativeMinHeap<T>.NativeMethodInfoPtr_HeapifyBottomToTop_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, 100665775);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public struct Element
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
      private static readonly System.IntPtr NativeFieldInfoPtr_ElementIndex;
      public float Weight;
      public int ElementIndex;

      static Element()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<NativeMinHeap<T>.Element>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, nameof (Element<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeMinHeap<T>.Element>.NativeClassPtr);
        NativeMinHeap<T>.Element.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMinHeap<T>.Element>.NativeClassPtr, nameof (Weight));
        NativeMinHeap<T>.Element.NativeFieldInfoPtr_ElementIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMinHeap<T>.Element>.NativeClassPtr, nameof (ElementIndex));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeMinHeap<T>.Element>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public struct TreeData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SizeOfTree;
      private static readonly System.IntPtr NativeFieldInfoPtr_FreeIndexCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_AllocatedIndexCount;
      public int SizeOfTree;
      public int FreeIndexCount;
      public int AllocatedIndexCount;

      static TreeData()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<NativeMinHeap<T>.TreeData>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeMinHeap<T>>.NativeClassPtr, nameof (TreeData<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeMinHeap<T>.TreeData>.NativeClassPtr);
        NativeMinHeap<T>.TreeData.NativeFieldInfoPtr_SizeOfTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMinHeap<T>.TreeData>.NativeClassPtr, nameof (SizeOfTree));
        NativeMinHeap<T>.TreeData.NativeFieldInfoPtr_FreeIndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMinHeap<T>.TreeData>.NativeClassPtr, nameof (FreeIndexCount));
        NativeMinHeap<T>.TreeData.NativeFieldInfoPtr_AllocatedIndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMinHeap<T>.TreeData>.NativeClassPtr, nameof (AllocatedIndexCount));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeMinHeap<T>.TreeData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
