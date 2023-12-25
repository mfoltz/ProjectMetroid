// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.AttackEntityCastOption
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AttackEntityCastOption
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TIMEOUT;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceAimInMoveDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityIndexRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_CooldownRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_InterruptCastOnTargetDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_InitialCastsCompletedRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastTargetPos;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartTimeRegister;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TickLogic_Private_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Finish_Private_BehaviourTreeResult_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CastAbility_Private_Boolean_Int32_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCooldown_Private_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    [FieldOffset(0)]
    public bool ForceAimInMoveDirection;
    [FieldOffset(4)]
    public SharedField<int> AbilityIndexRegister;
    [FieldOffset(8)]
    public SharedField<Entity> EntityRegister;
    [FieldOffset(12)]
    public SharedField<float> CooldownRegister;
    [FieldOffset(16)]
    public OptionalSharedField<bool> InterruptCastOnTargetDeath;
    [FieldOffset(24)]
    public PrivateField<int> InitialCastsCompletedRegister;
    [FieldOffset(28)]
    public PrivateField<float2> LastTargetPos;
    [FieldOffset(32)]
    public PrivateField<double> StartTimeRegister;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344106, XrefRangeEnd = 1344118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Initialize(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttackEntityCastOption.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344118, XrefRangeEnd = 1344137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Tick(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttackEntityCastOption.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1344188, RefRangeEnd = 1344190, XrefRangeStart = 1344137, XrefRangeEnd = 1344188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeResult TickLogic(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttackEntityCastOption.NativeMethodInfoPtr_TickLogic_Private_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344190, XrefRangeEnd = 1344191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Abort(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttackEntityCastOption.NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344191, XrefRangeEnd = 1344193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeResult Finish(
      BehaviourTreeResult result,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttackEntityCastOption.NativeMethodInfoPtr_Finish_Private_BehaviourTreeResult_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1344200, RefRangeEnd = 1344206, XrefRangeStart = 1344193, XrefRangeEnd = 1344200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Cleanup(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttackEntityCastOption.NativeMethodInfoPtr_Cleanup_Private_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1344235, RefRangeEnd = 1344236, XrefRangeStart = 1344206, XrefRangeEnd = 1344235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CastAbility(
      int abilityIndex,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &abilityIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttackEntityCastOption.NativeMethodInfoPtr_CastAbility_Private_Boolean_Int32_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1344264, RefRangeEnd = 1344267, XrefRangeStart = 1344236, XrefRangeEnd = 1344264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetCooldown(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttackEntityCastOption.NativeMethodInfoPtr_SetCooldown_Private_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AttackEntityCastOption()
    {
      Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (AttackEntityCastOption));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr);
      AttackEntityCastOption.NativeFieldInfoPtr_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr, nameof (TIMEOUT));
      AttackEntityCastOption.NativeFieldInfoPtr_ForceAimInMoveDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr, nameof (ForceAimInMoveDirection));
      AttackEntityCastOption.NativeFieldInfoPtr_AbilityIndexRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr, nameof (AbilityIndexRegister));
      AttackEntityCastOption.NativeFieldInfoPtr_EntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr, nameof (EntityRegister));
      AttackEntityCastOption.NativeFieldInfoPtr_CooldownRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr, nameof (CooldownRegister));
      AttackEntityCastOption.NativeFieldInfoPtr_InterruptCastOnTargetDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr, nameof (InterruptCastOnTargetDeath));
      AttackEntityCastOption.NativeFieldInfoPtr_InitialCastsCompletedRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr, nameof (InitialCastsCompletedRegister));
      AttackEntityCastOption.NativeFieldInfoPtr_LastTargetPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr, nameof (LastTargetPos));
      AttackEntityCastOption.NativeFieldInfoPtr_StartTimeRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr, nameof (StartTimeRegister));
      AttackEntityCastOption.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr, 100665410);
      AttackEntityCastOption.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr, 100665411);
      AttackEntityCastOption.NativeMethodInfoPtr_TickLogic_Private_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr, 100665412);
      AttackEntityCastOption.NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr, 100665413);
      AttackEntityCastOption.NativeMethodInfoPtr_Finish_Private_BehaviourTreeResult_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr, 100665414);
      AttackEntityCastOption.NativeMethodInfoPtr_Cleanup_Private_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr, 100665415);
      AttackEntityCastOption.NativeMethodInfoPtr_CastAbility_Private_Boolean_Int32_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr, 100665416);
      AttackEntityCastOption.NativeMethodInfoPtr_SetCooldown_Private_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr, 100665417);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttackEntityCastOption>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe float TIMEOUT
    {
      get
      {
        float timeout;
        IL2CPP.il2cpp_field_static_get_value(AttackEntityCastOption.NativeFieldInfoPtr_TIMEOUT, (void*) &timeout);
        return timeout;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AttackEntityCastOption.NativeFieldInfoPtr_TIMEOUT, (void*) &value);
      }
    }
  }
}
