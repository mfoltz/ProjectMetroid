// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.IConditionalAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using Unity.Collections;

#nullable disable
namespace ProjectM.Shared
{
  public class IConditionalAuthoring : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Abstract_Virtual_New_Void_byref_NativeArray_1_ConditionElement_byref_Int32_Int32_Int32_byref_NativeList_1_Int32_byref_NativeList_1_Int32_0;

    public virtual unsafe int Count
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IConditionalAuthoring.NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    public virtual unsafe void Build(
      ref NativeArray<ConditionElement> outConditions,
      ref int nextIndex,
      int successIndex,
      int failureIndex,
      ref NativeList<int> successIndices,
      ref NativeList<int> failureIndices)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[6];
      numPtr[0] = (IntPtr) ref outConditions;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref nextIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &successIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &failureIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) ref successIndices;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) ref failureIndices;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IConditionalAuthoring.NativeMethodInfoPtr_Build_Public_Abstract_Virtual_New_Void_byref_NativeArray_1_ConditionElement_byref_Int32_Int32_Int32_byref_NativeList_1_Int32_byref_NativeList_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IConditionalAuthoring()
    {
      Il2CppClassPointerStore<IConditionalAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (IConditionalAuthoring));
      IConditionalAuthoring.NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConditionalAuthoring>.NativeClassPtr, 100670573);
      IConditionalAuthoring.NativeMethodInfoPtr_Build_Public_Abstract_Virtual_New_Void_byref_NativeArray_1_ConditionElement_byref_Int32_Int32_Int32_byref_NativeList_1_Int32_byref_NativeList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConditionalAuthoring>.NativeClassPtr, 100670574);
    }

    public IConditionalAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
