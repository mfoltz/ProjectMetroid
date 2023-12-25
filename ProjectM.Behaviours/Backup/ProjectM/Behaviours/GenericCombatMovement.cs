// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.GenericCombatMovement
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GenericCombatMovement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CombatAreaRelocateDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionChangeDirectionCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExitReasonRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastBlockTimeRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastStuckCheckTime;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_BehaviourTreeResult_BehaviourTreeResult_GenericCombatMovementExitReason_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    [FieldOffset(0)]
    public float CombatAreaRelocateDistance;
    [FieldOffset(4)]
    public float CollisionChangeDirectionCooldown;
    [FieldOffset(8)]
    public SharedField<Entity> EntityRegister;
    [FieldOffset(12)]
    public SharedField<int> ExitReasonRegister;
    [FieldOffset(16)]
    public PrivateField<double> LastBlockTimeRegister;
    [FieldOffset(20)]
    public PrivateField<double> LastStuckCheckTime;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344755, XrefRangeEnd = 1344769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Initialize(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GenericCombatMovement.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344769, XrefRangeEnd = 1344821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Tick(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GenericCombatMovement.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344821, XrefRangeEnd = 1344822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Abort(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GenericCombatMovement.NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1344826, RefRangeEnd = 1344827, XrefRangeStart = 1344822, XrefRangeEnd = 1344826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeResult Exit(
      BehaviourTreeResult result,
      GenericCombatMovementExitReason exitReason,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &exitReason;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GenericCombatMovement.NativeMethodInfoPtr_Exit_Private_BehaviourTreeResult_BehaviourTreeResult_GenericCombatMovementExitReason_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1344834, RefRangeEnd = 1344836, XrefRangeStart = 1344827, XrefRangeEnd = 1344834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Cleanup(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GenericCombatMovement.NativeMethodInfoPtr_Cleanup_Private_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GenericCombatMovement()
    {
      Il2CppClassPointerStore<GenericCombatMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (GenericCombatMovement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericCombatMovement>.NativeClassPtr);
      GenericCombatMovement.NativeFieldInfoPtr_CombatAreaRelocateDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericCombatMovement>.NativeClassPtr, nameof (CombatAreaRelocateDistance));
      GenericCombatMovement.NativeFieldInfoPtr_CollisionChangeDirectionCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericCombatMovement>.NativeClassPtr, nameof (CollisionChangeDirectionCooldown));
      GenericCombatMovement.NativeFieldInfoPtr_EntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericCombatMovement>.NativeClassPtr, nameof (EntityRegister));
      GenericCombatMovement.NativeFieldInfoPtr_ExitReasonRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericCombatMovement>.NativeClassPtr, nameof (ExitReasonRegister));
      GenericCombatMovement.NativeFieldInfoPtr_LastBlockTimeRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericCombatMovement>.NativeClassPtr, nameof (LastBlockTimeRegister));
      GenericCombatMovement.NativeFieldInfoPtr_LastStuckCheckTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericCombatMovement>.NativeClassPtr, nameof (LastStuckCheckTime));
      GenericCombatMovement.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericCombatMovement>.NativeClassPtr, 100665469);
      GenericCombatMovement.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericCombatMovement>.NativeClassPtr, 100665470);
      GenericCombatMovement.NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericCombatMovement>.NativeClassPtr, 100665471);
      GenericCombatMovement.NativeMethodInfoPtr_Exit_Private_BehaviourTreeResult_BehaviourTreeResult_GenericCombatMovementExitReason_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericCombatMovement>.NativeClassPtr, 100665472);
      GenericCombatMovement.NativeMethodInfoPtr_Cleanup_Private_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericCombatMovement>.NativeClassPtr, 100665473);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GenericCombatMovement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
