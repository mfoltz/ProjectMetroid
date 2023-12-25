// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.FlowConditionFunctions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Entities;

#nullable disable
namespace Stunlock.Sequencer
{
  public static class FlowConditionFunctions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateConditions_Public_Static_Boolean_ConditionsEvaluationMode_byref_BlobArray_1_ConditionNew_byref_Blackboard_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoComparison_Private_Static_Boolean_ConditionType_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoComparison_Private_Static_Boolean_ConditionType_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoComparison_Private_Static_Boolean_ConditionType_Boolean_Boolean_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 923415, RefRangeEnd = 923416, XrefRangeStart = 923390, XrefRangeEnd = 923415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool EvaluateConditions(
      ConditionsEvaluationMode evaluationMode,
      ref BlobArray<ConditionNew> conditions,
      ref Blackboard blackboard)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &evaluationMode;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref conditions;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref blackboard;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlowConditionFunctions.NativeMethodInfoPtr_EvaluateConditions_Public_Static_Boolean_ConditionsEvaluationMode_byref_BlobArray_1_ConditionNew_byref_Blackboard_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 923416, RefRangeEnd = 923417, XrefRangeStart = 923416, XrefRangeEnd = 923416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool DoComparison(ConditionType conditionType, int a, int b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &conditionType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlowConditionFunctions.NativeMethodInfoPtr_DoComparison_Private_Static_Boolean_ConditionType_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 923417, RefRangeEnd = 923418, XrefRangeStart = 923417, XrefRangeEnd = 923417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool DoComparison(ConditionType conditionType, float a, float b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &conditionType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlowConditionFunctions.NativeMethodInfoPtr_DoComparison_Private_Static_Boolean_ConditionType_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 923418, RefRangeEnd = 923419, XrefRangeStart = 923418, XrefRangeEnd = 923418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool DoComparison(ConditionType conditionType, bool a, bool b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &conditionType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlowConditionFunctions.NativeMethodInfoPtr_DoComparison_Private_Static_Boolean_ConditionType_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static FlowConditionFunctions()
    {
      Il2CppClassPointerStore<FlowConditionFunctions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer", nameof (FlowConditionFunctions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowConditionFunctions>.NativeClassPtr);
      FlowConditionFunctions.NativeMethodInfoPtr_EvaluateConditions_Public_Static_Boolean_ConditionsEvaluationMode_byref_BlobArray_1_ConditionNew_byref_Blackboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowConditionFunctions>.NativeClassPtr, 100663874);
      FlowConditionFunctions.NativeMethodInfoPtr_DoComparison_Private_Static_Boolean_ConditionType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowConditionFunctions>.NativeClassPtr, 100663875);
      FlowConditionFunctions.NativeMethodInfoPtr_DoComparison_Private_Static_Boolean_ConditionType_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowConditionFunctions>.NativeClassPtr, 100663876);
      FlowConditionFunctions.NativeMethodInfoPtr_DoComparison_Private_Static_Boolean_ConditionType_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowConditionFunctions>.NativeClassPtr, 100663877);
    }

    public FlowConditionFunctions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
