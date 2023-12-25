// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.ApproachPosition
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ApproachPosition
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetMinDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetMaxDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetGoalDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_SucceedOnTargetReached;
    private static readonly System.IntPtr NativeFieldInfoPtr_FreezeRotationWhenStationary;
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionRegister;
    private static readonly System.IntPtr NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_BehaviourTreeResult_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    [FieldOffset(0)]
    public float TargetMinDistance;
    [FieldOffset(4)]
    public float TargetMaxDistance;
    [FieldOffset(8)]
    public float TargetGoalDistance;
    [FieldOffset(12)]
    public bool SucceedOnTargetReached;
    [FieldOffset(13)]
    public bool FreezeRotationWhenStationary;
    [FieldOffset(16)]
    public SharedField<float3> PositionRegister;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344027, XrefRangeEnd = 1344052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Tick(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ApproachPosition.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344052, XrefRangeEnd = 1344053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Abort(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ApproachPosition.NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344053, XrefRangeEnd = 1344054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeResult Exit(
      BehaviourTreeResult result,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ApproachPosition.NativeMethodInfoPtr_Exit_Private_BehaviourTreeResult_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1344060, RefRangeEnd = 1344063, XrefRangeStart = 1344054, XrefRangeEnd = 1344060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Cleanup(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ApproachPosition.NativeMethodInfoPtr_Cleanup_Private_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ApproachPosition()
    {
      Il2CppClassPointerStore<ApproachPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (ApproachPosition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApproachPosition>.NativeClassPtr);
      ApproachPosition.NativeFieldInfoPtr_TargetMinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApproachPosition>.NativeClassPtr, nameof (TargetMinDistance));
      ApproachPosition.NativeFieldInfoPtr_TargetMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApproachPosition>.NativeClassPtr, nameof (TargetMaxDistance));
      ApproachPosition.NativeFieldInfoPtr_TargetGoalDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApproachPosition>.NativeClassPtr, nameof (TargetGoalDistance));
      ApproachPosition.NativeFieldInfoPtr_SucceedOnTargetReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApproachPosition>.NativeClassPtr, nameof (SucceedOnTargetReached));
      ApproachPosition.NativeFieldInfoPtr_FreezeRotationWhenStationary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApproachPosition>.NativeClassPtr, nameof (FreezeRotationWhenStationary));
      ApproachPosition.NativeFieldInfoPtr_PositionRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApproachPosition>.NativeClassPtr, nameof (PositionRegister));
      ApproachPosition.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApproachPosition>.NativeClassPtr, 100665402);
      ApproachPosition.NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApproachPosition>.NativeClassPtr, 100665403);
      ApproachPosition.NativeMethodInfoPtr_Exit_Private_BehaviourTreeResult_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApproachPosition>.NativeClassPtr, 100665404);
      ApproachPosition.NativeMethodInfoPtr_Cleanup_Private_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApproachPosition>.NativeClassPtr, 100665405);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ApproachPosition>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
