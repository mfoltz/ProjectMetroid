// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.PatrolTeleport
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
  public struct PatrolTeleport
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionRegister;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsCastleFloorAtPosition_Private_Boolean_byref_BehaviourTreeJobData_float2_0;
    [FieldOffset(0)]
    public SharedField<float3> PositionRegister;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345212, XrefRangeEnd = 1345228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Initialize(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolTeleport.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1345242, RefRangeEnd = 1345243, XrefRangeStart = 1345228, XrefRangeEnd = 1345242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsCastleFloorAtPosition(ref BehaviourTreeJobData jobData, float2 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolTeleport.NativeMethodInfoPtr_IsCastleFloorAtPosition_Private_Boolean_byref_BehaviourTreeJobData_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PatrolTeleport()
    {
      Il2CppClassPointerStore<PatrolTeleport>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (PatrolTeleport));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolTeleport>.NativeClassPtr);
      PatrolTeleport.NativeFieldInfoPtr_PositionRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolTeleport>.NativeClassPtr, nameof (PositionRegister));
      PatrolTeleport.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolTeleport>.NativeClassPtr, 100665519);
      PatrolTeleport.NativeMethodInfoPtr_IsCastleFloorAtPosition_Private_Boolean_byref_BehaviourTreeJobData_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolTeleport>.NativeClassPtr, 100665520);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolTeleport>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
