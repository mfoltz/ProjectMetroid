// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerTakeDamageOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LogPlayerTakeDamageOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_VictimPlayerHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_VictimPlayerPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_VictimPlayerViewRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AttackerPlayerHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AttackerPlayerPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AttackerPlayerViewRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IsHitscanAttack;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_HasLineOfSight;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IsCriticalHit;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_HitBoneId_DEPRECATED;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DamageTaken;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_HealthRemaining;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DamageSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DamageType;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DamageResult;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerUseWeaponData;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_TimeSincePlayerUseWeaponMs;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DamagePosition;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_VictimPlayerHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_VictimPlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_VictimPlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AttackerPlayerHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AttackerPlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AttackerPlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsHitscanAttack_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_HasLineOfSight_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsCriticalHit_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_HitBoneId_DEPRECATED_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DamageTaken_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_HealthRemaining_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DamageSource_Public_set_Void_AntiCheatCommonPlayerTakeDamageSource_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DamageType_Public_set_Void_AntiCheatCommonPlayerTakeDamageType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DamageResult_Public_set_Void_AntiCheatCommonPlayerTakeDamageResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerUseWeaponData_Public_set_Void_Nullable_1_LogPlayerUseWeaponData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSincePlayerUseWeaponMs_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DamagePosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogPlayerTakeDamageOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogPlayerTakeDamageOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_VictimPlayerHandle;
    [FieldOffset(16)]
    public System.IntPtr m_VictimPlayerPosition;
    [FieldOffset(24)]
    public System.IntPtr m_VictimPlayerViewRotation;
    [FieldOffset(32)]
    public System.IntPtr m_AttackerPlayerHandle;
    [FieldOffset(40)]
    public System.IntPtr m_AttackerPlayerPosition;
    [FieldOffset(48)]
    public System.IntPtr m_AttackerPlayerViewRotation;
    [FieldOffset(56)]
    public int m_IsHitscanAttack;
    [FieldOffset(60)]
    public int m_HasLineOfSight;
    [FieldOffset(64)]
    public int m_IsCriticalHit;
    [FieldOffset(68)]
    public uint m_HitBoneId_DEPRECATED;
    [FieldOffset(72)]
    public float m_DamageTaken;
    [FieldOffset(76)]
    public float m_HealthRemaining;
    [FieldOffset(80)]
    public AntiCheatCommonPlayerTakeDamageSource m_DamageSource;
    [FieldOffset(84)]
    public AntiCheatCommonPlayerTakeDamageType m_DamageType;
    [FieldOffset(88)]
    public AntiCheatCommonPlayerTakeDamageResult m_DamageResult;
    [FieldOffset(96)]
    public System.IntPtr m_PlayerUseWeaponData;
    [FieldOffset(104)]
    public uint m_TimeSincePlayerUseWeaponMs;
    [FieldOffset(112)]
    public System.IntPtr m_DamagePosition;

    public unsafe System.IntPtr VictimPlayerHandle
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_VictimPlayerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Vec3f> VictimPlayerPosition
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970064, XrefRangeEnd = 970070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_VictimPlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Quat> VictimPlayerViewRotation
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970070, XrefRangeEnd = 970076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_VictimPlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe System.IntPtr AttackerPlayerHandle
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_AttackerPlayerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Vec3f> AttackerPlayerPosition
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970076, XrefRangeEnd = 970082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_AttackerPlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Quat> AttackerPlayerViewRotation
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970082, XrefRangeEnd = 970088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_AttackerPlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsHitscanAttack
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970088, XrefRangeEnd = 970092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_IsHitscanAttack_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool HasLineOfSight
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970092, XrefRangeEnd = 970096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_HasLineOfSight_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsCriticalHit
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970096, XrefRangeEnd = 970100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_IsCriticalHit_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint HitBoneId_DEPRECATED
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_HitBoneId_DEPRECATED_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float DamageTaken
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 632295, RefRangeEnd = 632296, XrefRangeStart = 632295, XrefRangeEnd = 632296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamageTaken_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float HealthRemaining
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 632297, RefRangeEnd = 632298, XrefRangeStart = 632297, XrefRangeEnd = 632298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_HealthRemaining_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonPlayerTakeDamageSource DamageSource
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamageSource_Public_set_Void_AntiCheatCommonPlayerTakeDamageSource_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonPlayerTakeDamageType DamageType
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamageType_Public_set_Void_AntiCheatCommonPlayerTakeDamageType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonPlayerTakeDamageResult DamageResult
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 86269, RefRangeEnd = 86272, XrefRangeStart = 86269, XrefRangeEnd = 86272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamageResult_Public_set_Void_AntiCheatCommonPlayerTakeDamageResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.Nullable<LogPlayerUseWeaponData> PlayerUseWeaponData
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970100, XrefRangeEnd = 970106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_PlayerUseWeaponData_Public_set_Void_Nullable_1_LogPlayerUseWeaponData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint TimeSincePlayerUseWeaponMs
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 70661, RefRangeEnd = 70670, XrefRangeStart = 70661, XrefRangeEnd = 70670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_TimeSincePlayerUseWeaponMs_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Vec3f> DamagePosition
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970106, XrefRangeEnd = 970112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamagePosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 970160, RefRangeEnd = 970161, XrefRangeStart = 970112, XrefRangeEnd = 970160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref LogPlayerTakeDamageOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogPlayerTakeDamageOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970161, XrefRangeEnd = 970247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<LogPlayerTakeDamageOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogPlayerTakeDamageOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970247, XrefRangeEnd = 970258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LogPlayerTakeDamageOptionsInternal()
    {
      Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerTakeDamageOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr);
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_VictimPlayerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_VictimPlayerHandle));
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_VictimPlayerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_VictimPlayerPosition));
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_VictimPlayerViewRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_VictimPlayerViewRotation));
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_AttackerPlayerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_AttackerPlayerHandle));
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_AttackerPlayerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_AttackerPlayerPosition));
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_AttackerPlayerViewRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_AttackerPlayerViewRotation));
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_IsHitscanAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_IsHitscanAttack));
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_HasLineOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_HasLineOfSight));
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_IsCriticalHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_IsCriticalHit));
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_HitBoneId_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_HitBoneId_DEPRECATED));
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_DamageTaken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_DamageTaken));
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_HealthRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_HealthRemaining));
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_DamageSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_DamageSource));
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_DamageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_DamageType));
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_DamageResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_DamageResult));
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_PlayerUseWeaponData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_PlayerUseWeaponData));
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_TimeSincePlayerUseWeaponMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_TimeSincePlayerUseWeaponMs));
      LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_DamagePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_DamagePosition));
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_VictimPlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674079);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_VictimPlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674080);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_VictimPlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674081);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_AttackerPlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674082);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_AttackerPlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674083);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_AttackerPlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674084);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_IsHitscanAttack_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674085);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_HasLineOfSight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674086);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_IsCriticalHit_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674087);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_HitBoneId_DEPRECATED_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674088);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamageTaken_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674089);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_HealthRemaining_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674090);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamageSource_Public_set_Void_AntiCheatCommonPlayerTakeDamageSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674091);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamageType_Public_set_Void_AntiCheatCommonPlayerTakeDamageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674092);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamageResult_Public_set_Void_AntiCheatCommonPlayerTakeDamageResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674093);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_PlayerUseWeaponData_Public_set_Void_Nullable_1_LogPlayerUseWeaponData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674094);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_TimeSincePlayerUseWeaponMs_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674095);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamagePosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674096);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogPlayerTakeDamageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674097);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogPlayerTakeDamageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674098);
      LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100674099);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
