// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.DelayUntilDamageTakenShared
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM.Behaviours
{
  public static class DelayUntilDamageTakenShared : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_Single_PrivateField_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfBelowThreshold_Public_Static_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_PrivateField_1_Single_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1344358, RefRangeEnd = 1344360, XrefRangeStart = 1344351, XrefRangeEnd = 1344358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeResult Initialize(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData,
      float healthLossThreshold,
      PrivateField<float> healthThresholdRegister)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &healthLossThreshold;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &healthThresholdRegister;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DelayUntilDamageTakenShared.NativeMethodInfoPtr_Initialize_Public_Static_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_Single_PrivateField_1_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1344366, RefRangeEnd = 1344369, XrefRangeStart = 1344360, XrefRangeEnd = 1344366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeResult CheckIfBelowThreshold(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData,
      PrivateField<float> healthThresholdRegister)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &healthThresholdRegister;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DelayUntilDamageTakenShared.NativeMethodInfoPtr_CheckIfBelowThreshold_Public_Static_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_PrivateField_1_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DelayUntilDamageTakenShared()
    {
      Il2CppClassPointerStore<DelayUntilDamageTakenShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (DelayUntilDamageTakenShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelayUntilDamageTakenShared>.NativeClassPtr);
      DelayUntilDamageTakenShared.NativeMethodInfoPtr_Initialize_Public_Static_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_Single_PrivateField_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayUntilDamageTakenShared>.NativeClassPtr, 100665432);
      DelayUntilDamageTakenShared.NativeMethodInfoPtr_CheckIfBelowThreshold_Public_Static_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_PrivateField_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayUntilDamageTakenShared>.NativeClassPtr, 100665433);
    }

    public DelayUntilDamageTakenShared(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
