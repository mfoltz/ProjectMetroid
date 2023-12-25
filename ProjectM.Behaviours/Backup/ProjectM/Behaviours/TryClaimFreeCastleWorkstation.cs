// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.TryClaimFreeCastleWorkstation
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TryClaimFreeCastleWorkstation
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OutRegister;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Succeed_Private_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_NativeArray_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsPreferred_Private_Boolean_PrefabGUID_NativeArray_1_ServantPreferredWorkstationsBuffer_0;
    [FieldOffset(0)]
    public SharedField<Entity> OutRegister;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345808, XrefRangeEnd = 1345863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Initialize(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TryClaimFreeCastleWorkstation.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1345880, RefRangeEnd = 1345881, XrefRangeStart = 1345863, XrefRangeEnd = 1345880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeResult Succeed(
      [In] ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData,
      NativeArray<Entity> candidates)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &candidates;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TryClaimFreeCastleWorkstation.NativeMethodInfoPtr_Succeed_Private_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_NativeArray_1_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345881, XrefRangeEnd = 1345882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsPreferred(
      PrefabGUID workstationPrefabGuid,
      NativeArray<ServantPreferredWorkstationsBuffer> preferredWorkstations)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &workstationPrefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &preferredWorkstations;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TryClaimFreeCastleWorkstation.NativeMethodInfoPtr_IsPreferred_Private_Boolean_PrefabGUID_NativeArray_1_ServantPreferredWorkstationsBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TryClaimFreeCastleWorkstation()
    {
      Il2CppClassPointerStore<TryClaimFreeCastleWorkstation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (TryClaimFreeCastleWorkstation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TryClaimFreeCastleWorkstation>.NativeClassPtr);
      TryClaimFreeCastleWorkstation.NativeFieldInfoPtr_OutRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryClaimFreeCastleWorkstation>.NativeClassPtr, nameof (OutRegister));
      TryClaimFreeCastleWorkstation.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryClaimFreeCastleWorkstation>.NativeClassPtr, 100665565);
      TryClaimFreeCastleWorkstation.NativeMethodInfoPtr_Succeed_Private_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_NativeArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryClaimFreeCastleWorkstation>.NativeClassPtr, 100665566);
      TryClaimFreeCastleWorkstation.NativeMethodInfoPtr_IsPreferred_Private_Boolean_PrefabGUID_NativeArray_1_ServantPreferredWorkstationsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryClaimFreeCastleWorkstation>.NativeClassPtr, 100665567);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TryClaimFreeCastleWorkstation>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
