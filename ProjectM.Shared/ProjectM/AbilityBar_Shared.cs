// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityBar_Shared
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityBar_Shared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LimitAbilityPriority;
    private static readonly System.IntPtr NativeFieldInfoPtr_GlobalCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastStartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_PostCastTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_InterruptTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_CooldownOnInterrupt;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerInterruptCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastStartedCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastCompletedCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerCastCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceCastGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_ThisFrameState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastAbility;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastGroupPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastAbilityPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_CooldownModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryCooldownModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_TravelCooldownModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponCooldownModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellCooldownModifier;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalCastTime_Private_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentCastTime_Public_Single_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentPostCastTime_Private_Single_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentTotalCastTime_Public_Single_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsCasting_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsPreCasting_Public_Boolean_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsPostCasting_Public_Boolean_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasPostCast_Public_Boolean_0;
    [FieldOffset(0)]
    public ModifiableInt LimitAbilityPriority;
    [FieldOffset(8)]
    public float GlobalCooldown;
    [FieldOffset(16)]
    public double CastStartTime;
    [FieldOffset(24)]
    public float CastTime;
    [FieldOffset(28)]
    public float PostCastTime;
    [FieldOffset(32)]
    public InterruptTypes InterruptTypes;
    [FieldOffset(36)]
    public float CooldownOnInterrupt;
    [FieldOffset(40)]
    public int ServerInterruptCounter;
    [FieldOffset(44)]
    public int CastStartedCounter;
    [FieldOffset(48)]
    public int CastCompletedCounter;
    [FieldOffset(52)]
    public int ServerCastCounter;
    [FieldOffset(56)]
    public PrefabGUID ForceCastGroup;
    [FieldOffset(60)]
    public NetworkedEntity CastGroup;
    [FieldOffset(72)]
    public AbilityCastingState ThisFrameState;
    [FieldOffset(76)]
    public NetworkedEntity CastAbility;
    [FieldOffset(88)]
    public PrefabGUID CastGroupPrefabGuid;
    [FieldOffset(92)]
    public PrefabGUID CastAbilityPrefabGuid;
    [FieldOffset(96)]
    public ModifiableFloat CooldownModifier;
    [FieldOffset(104)]
    public ModifiableFloat PrimaryCooldownModifier;
    [FieldOffset(112)]
    public ModifiableFloat TravelCooldownModifier;
    [FieldOffset(120)]
    public ModifiableFloat WeaponCooldownModifier;
    [FieldOffset(128)]
    public ModifiableFloat SpellCooldownModifier;

    public unsafe float TotalCastTime
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityBar_Shared.NativeMethodInfoPtr_get_TotalCastTime_Private_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 720186, RefRangeEnd = 720192, XrefRangeStart = 720186, XrefRangeEnd = 720186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetCurrentCastTime(double serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityBar_Shared.NativeMethodInfoPtr_GetCurrentCastTime_Public_Single_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe float GetCurrentPostCastTime(double serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityBar_Shared.NativeMethodInfoPtr_GetCurrentPostCastTime_Private_Single_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 720186, RefRangeEnd = 720192, XrefRangeStart = 720186, XrefRangeEnd = 720192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetCurrentTotalCastTime(double serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityBar_Shared.NativeMethodInfoPtr_GetCurrentTotalCastTime_Public_Single_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 720193, RefRangeEnd = 720216, XrefRangeStart = 720192, XrefRangeEnd = 720193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsCasting()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityBar_Shared.NativeMethodInfoPtr_IsCasting_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 720217, RefRangeEnd = 720228, XrefRangeStart = 720216, XrefRangeEnd = 720217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsPreCasting(double serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityBar_Shared.NativeMethodInfoPtr_IsPreCasting_Public_Boolean_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 720230, RefRangeEnd = 720237, XrefRangeStart = 720228, XrefRangeEnd = 720230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsPostCasting(double serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityBar_Shared.NativeMethodInfoPtr_IsPostCasting_Public_Boolean_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720237, XrefRangeEnd = 720238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasPostCast()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityBar_Shared.NativeMethodInfoPtr_HasPostCast_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AbilityBar_Shared()
    {
      Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityBar_Shared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr);
      AbilityBar_Shared.NativeFieldInfoPtr_LimitAbilityPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (LimitAbilityPriority));
      AbilityBar_Shared.NativeFieldInfoPtr_GlobalCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (GlobalCooldown));
      AbilityBar_Shared.NativeFieldInfoPtr_CastStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (CastStartTime));
      AbilityBar_Shared.NativeFieldInfoPtr_CastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (CastTime));
      AbilityBar_Shared.NativeFieldInfoPtr_PostCastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (PostCastTime));
      AbilityBar_Shared.NativeFieldInfoPtr_InterruptTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (InterruptTypes));
      AbilityBar_Shared.NativeFieldInfoPtr_CooldownOnInterrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (CooldownOnInterrupt));
      AbilityBar_Shared.NativeFieldInfoPtr_ServerInterruptCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (ServerInterruptCounter));
      AbilityBar_Shared.NativeFieldInfoPtr_CastStartedCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (CastStartedCounter));
      AbilityBar_Shared.NativeFieldInfoPtr_CastCompletedCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (CastCompletedCounter));
      AbilityBar_Shared.NativeFieldInfoPtr_ServerCastCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (ServerCastCounter));
      AbilityBar_Shared.NativeFieldInfoPtr_ForceCastGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (ForceCastGroup));
      AbilityBar_Shared.NativeFieldInfoPtr_CastGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (CastGroup));
      AbilityBar_Shared.NativeFieldInfoPtr_ThisFrameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (ThisFrameState));
      AbilityBar_Shared.NativeFieldInfoPtr_CastAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (CastAbility));
      AbilityBar_Shared.NativeFieldInfoPtr_CastGroupPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (CastGroupPrefabGuid));
      AbilityBar_Shared.NativeFieldInfoPtr_CastAbilityPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (CastAbilityPrefabGuid));
      AbilityBar_Shared.NativeFieldInfoPtr_CooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (CooldownModifier));
      AbilityBar_Shared.NativeFieldInfoPtr_PrimaryCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (PrimaryCooldownModifier));
      AbilityBar_Shared.NativeFieldInfoPtr_TravelCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (TravelCooldownModifier));
      AbilityBar_Shared.NativeFieldInfoPtr_WeaponCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (WeaponCooldownModifier));
      AbilityBar_Shared.NativeFieldInfoPtr_SpellCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, nameof (SpellCooldownModifier));
      AbilityBar_Shared.NativeMethodInfoPtr_get_TotalCastTime_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, 100663652);
      AbilityBar_Shared.NativeMethodInfoPtr_GetCurrentCastTime_Public_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, 100663653);
      AbilityBar_Shared.NativeMethodInfoPtr_GetCurrentPostCastTime_Private_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, 100663654);
      AbilityBar_Shared.NativeMethodInfoPtr_GetCurrentTotalCastTime_Public_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, 100663655);
      AbilityBar_Shared.NativeMethodInfoPtr_IsCasting_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, 100663656);
      AbilityBar_Shared.NativeMethodInfoPtr_IsPreCasting_Public_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, 100663657);
      AbilityBar_Shared.NativeMethodInfoPtr_IsPostCasting_Public_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, 100663658);
      AbilityBar_Shared.NativeMethodInfoPtr_HasPostCast_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, 100663659);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityBar_Shared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
