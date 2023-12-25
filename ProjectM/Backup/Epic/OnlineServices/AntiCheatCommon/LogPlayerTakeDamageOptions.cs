// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerTakeDamageOptions
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
  public sealed class LogPlayerTakeDamageOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__VictimPlayerHandle_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__VictimPlayerPosition_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__VictimPlayerViewRotation_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__AttackerPlayerHandle_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__AttackerPlayerPosition_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__AttackerPlayerViewRotation_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsHitscanAttack_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__HasLineOfSight_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsCriticalHit_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__HitBoneId_DEPRECATED_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__DamageTaken_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__HealthRemaining_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__DamageSource_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__DamageType_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__DamageResult_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlayerUseWeaponData_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__TimeSincePlayerUseWeaponMs_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__DamagePosition_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_VictimPlayerHandle_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_VictimPlayerHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_VictimPlayerPosition_Public_get_Nullable_Unboxed_1_Vec3f_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_VictimPlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_VictimPlayerViewRotation_Public_get_Nullable_Unboxed_1_Quat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_VictimPlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AttackerPlayerHandle_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AttackerPlayerHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AttackerPlayerPosition_Public_get_Nullable_Unboxed_1_Vec3f_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AttackerPlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AttackerPlayerViewRotation_Public_get_Nullable_Unboxed_1_Quat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AttackerPlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsHitscanAttack_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsHitscanAttack_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HasLineOfSight_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_HasLineOfSight_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCriticalHit_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsCriticalHit_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HitBoneId_DEPRECATED_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_HitBoneId_DEPRECATED_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DamageTaken_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DamageTaken_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HealthRemaining_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_HealthRemaining_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DamageSource_Public_get_AntiCheatCommonPlayerTakeDamageSource_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DamageSource_Public_set_Void_AntiCheatCommonPlayerTakeDamageSource_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DamageType_Public_get_AntiCheatCommonPlayerTakeDamageType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DamageType_Public_set_Void_AntiCheatCommonPlayerTakeDamageType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DamageResult_Public_get_AntiCheatCommonPlayerTakeDamageResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DamageResult_Public_set_Void_AntiCheatCommonPlayerTakeDamageResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerUseWeaponData_Public_get_Nullable_1_LogPlayerUseWeaponData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerUseWeaponData_Public_set_Void_Nullable_1_LogPlayerUseWeaponData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSincePlayerUseWeaponMs_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSincePlayerUseWeaponMs_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DamagePosition_Public_get_Nullable_Unboxed_1_Vec3f_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DamagePosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0;

    public unsafe System.IntPtr VictimPlayerHandle
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_VictimPlayerHandle_Public_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_VictimPlayerHandle_Public_set_Void_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Vec3f> VictimPlayerPosition
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_VictimPlayerPosition_Public_get_Nullable_Unboxed_1_Vec3f_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<Vec3f>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_VictimPlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Quat> VictimPlayerViewRotation
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_VictimPlayerViewRotation_Public_get_Nullable_Unboxed_1_Quat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<Quat>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_VictimPlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe System.IntPtr AttackerPlayerHandle
    {
      [CallerCount(343), CachedScanResults(RefRangeStart = 22462, RefRangeEnd = 22805, XrefRangeStart = 22462, XrefRangeEnd = 22805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_AttackerPlayerHandle_Public_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_AttackerPlayerHandle_Public_set_Void_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Vec3f> AttackerPlayerPosition
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_AttackerPlayerPosition_Public_get_Nullable_Unboxed_1_Vec3f_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<Vec3f>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_AttackerPlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Quat> AttackerPlayerViewRotation
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_AttackerPlayerViewRotation_Public_get_Nullable_Unboxed_1_Quat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<Quat>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_AttackerPlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsHitscanAttack
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_IsHitscanAttack_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_IsHitscanAttack_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool HasLineOfSight
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_HasLineOfSight_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_HasLineOfSight_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsCriticalHit
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_IsCriticalHit_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_IsCriticalHit_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint HitBoneId_DEPRECATED
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_HitBoneId_DEPRECATED_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(174), CachedScanResults(RefRangeStart = 95032, RefRangeEnd = 95206, XrefRangeStart = 95032, XrefRangeEnd = 95206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_HitBoneId_DEPRECATED_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float DamageTaken
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 587828, RefRangeEnd = 587829, XrefRangeStart = 587828, XrefRangeEnd = 587829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamageTaken_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 247047, RefRangeEnd = 247048, XrefRangeStart = 247047, XrefRangeEnd = 247048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamageTaken_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float HealthRemaining
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 561297, RefRangeEnd = 561300, XrefRangeStart = 561297, XrefRangeEnd = 561300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_HealthRemaining_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 247054, RefRangeEnd = 247056, XrefRangeStart = 247054, XrefRangeEnd = 247056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_HealthRemaining_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonPlayerTakeDamageSource DamageSource
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamageSource_Public_get_AntiCheatCommonPlayerTakeDamageSource_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AntiCheatCommonPlayerTakeDamageSource*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamageSource_Public_set_Void_AntiCheatCommonPlayerTakeDamageSource_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonPlayerTakeDamageType DamageType
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 47618, RefRangeEnd = 47619, XrefRangeStart = 47618, XrefRangeEnd = 47619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamageType_Public_get_AntiCheatCommonPlayerTakeDamageType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AntiCheatCommonPlayerTakeDamageType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamageType_Public_set_Void_AntiCheatCommonPlayerTakeDamageType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonPlayerTakeDamageResult DamageResult
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 47619, RefRangeEnd = 47620, XrefRangeStart = 47619, XrefRangeEnd = 47620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamageResult_Public_get_AntiCheatCommonPlayerTakeDamageResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AntiCheatCommonPlayerTakeDamageResult*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamageResult_Public_set_Void_AntiCheatCommonPlayerTakeDamageResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.Nullable<LogPlayerUseWeaponData> PlayerUseWeaponData
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_PlayerUseWeaponData_Public_get_Nullable_1_LogPlayerUseWeaponData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.Nullable<LogPlayerUseWeaponData>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970063, XrefRangeEnd = 970064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_PlayerUseWeaponData_Public_set_Void_Nullable_1_LogPlayerUseWeaponData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint TimeSincePlayerUseWeaponMs
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_TimeSincePlayerUseWeaponMs_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_TimeSincePlayerUseWeaponMs_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Vec3f> DamagePosition
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamagePosition_Public_get_Nullable_Unboxed_1_Vec3f_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<Vec3f>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamagePosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static LogPlayerTakeDamageOptions()
    {
      Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerTakeDamageOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr);
      LogPlayerTakeDamageOptions.NativeFieldInfoPtr__VictimPlayerHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<VictimPlayerHandle>k__BackingField");
      LogPlayerTakeDamageOptions.NativeFieldInfoPtr__VictimPlayerPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<VictimPlayerPosition>k__BackingField");
      LogPlayerTakeDamageOptions.NativeFieldInfoPtr__VictimPlayerViewRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<VictimPlayerViewRotation>k__BackingField");
      LogPlayerTakeDamageOptions.NativeFieldInfoPtr__AttackerPlayerHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<AttackerPlayerHandle>k__BackingField");
      LogPlayerTakeDamageOptions.NativeFieldInfoPtr__AttackerPlayerPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<AttackerPlayerPosition>k__BackingField");
      LogPlayerTakeDamageOptions.NativeFieldInfoPtr__AttackerPlayerViewRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<AttackerPlayerViewRotation>k__BackingField");
      LogPlayerTakeDamageOptions.NativeFieldInfoPtr__IsHitscanAttack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<IsHitscanAttack>k__BackingField");
      LogPlayerTakeDamageOptions.NativeFieldInfoPtr__HasLineOfSight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<HasLineOfSight>k__BackingField");
      LogPlayerTakeDamageOptions.NativeFieldInfoPtr__IsCriticalHit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<IsCriticalHit>k__BackingField");
      LogPlayerTakeDamageOptions.NativeFieldInfoPtr__HitBoneId_DEPRECATED_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<HitBoneId_DEPRECATED>k__BackingField");
      LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageTaken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<DamageTaken>k__BackingField");
      LogPlayerTakeDamageOptions.NativeFieldInfoPtr__HealthRemaining_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<HealthRemaining>k__BackingField");
      LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<DamageSource>k__BackingField");
      LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<DamageType>k__BackingField");
      LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<DamageResult>k__BackingField");
      LogPlayerTakeDamageOptions.NativeFieldInfoPtr__PlayerUseWeaponData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<PlayerUseWeaponData>k__BackingField");
      LogPlayerTakeDamageOptions.NativeFieldInfoPtr__TimeSincePlayerUseWeaponMs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<TimeSincePlayerUseWeaponMs>k__BackingField");
      LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamagePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<DamagePosition>k__BackingField");
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_VictimPlayerHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674043);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_VictimPlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674044);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_VictimPlayerPosition_Public_get_Nullable_Unboxed_1_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674045);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_VictimPlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674046);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_VictimPlayerViewRotation_Public_get_Nullable_Unboxed_1_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674047);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_VictimPlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674048);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_AttackerPlayerHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674049);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_AttackerPlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674050);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_AttackerPlayerPosition_Public_get_Nullable_Unboxed_1_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674051);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_AttackerPlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674052);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_AttackerPlayerViewRotation_Public_get_Nullable_Unboxed_1_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674053);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_AttackerPlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674054);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_IsHitscanAttack_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674055);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_IsHitscanAttack_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674056);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_HasLineOfSight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674057);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_HasLineOfSight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674058);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_IsCriticalHit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674059);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_IsCriticalHit_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674060);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_HitBoneId_DEPRECATED_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674061);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_HitBoneId_DEPRECATED_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674062);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamageTaken_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674063);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamageTaken_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674064);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_HealthRemaining_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674065);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_HealthRemaining_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674066);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamageSource_Public_get_AntiCheatCommonPlayerTakeDamageSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674067);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamageSource_Public_set_Void_AntiCheatCommonPlayerTakeDamageSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674068);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamageType_Public_get_AntiCheatCommonPlayerTakeDamageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674069);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamageType_Public_set_Void_AntiCheatCommonPlayerTakeDamageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674070);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamageResult_Public_get_AntiCheatCommonPlayerTakeDamageResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674071);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamageResult_Public_set_Void_AntiCheatCommonPlayerTakeDamageResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674072);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_PlayerUseWeaponData_Public_get_Nullable_1_LogPlayerUseWeaponData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674073);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_PlayerUseWeaponData_Public_set_Void_Nullable_1_LogPlayerUseWeaponData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674074);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_TimeSincePlayerUseWeaponMs_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674075);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_TimeSincePlayerUseWeaponMs_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674076);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamagePosition_Public_get_Nullable_Unboxed_1_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674077);
      LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamagePosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100674078);
    }

    public LogPlayerTakeDamageOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public LogPlayerTakeDamageOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, data));
    }

    public unsafe System.IntPtr _VictimPlayerHandle_k__BackingField
    {
      get
      {
        return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__VictimPlayerHandle_k__BackingField));
      }
      [param: In] set
      {
        *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__VictimPlayerHandle_k__BackingField)) = value;
      }
    }

    public unsafe Nullable_Unboxed<Vec3f> _VictimPlayerPosition_k__BackingField
    {
      get
      {
        return *(Nullable_Unboxed<Vec3f>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__VictimPlayerPosition_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__VictimPlayerPosition_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<Vec3f>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<Quat> _VictimPlayerViewRotation_k__BackingField
    {
      get
      {
        return *(Nullable_Unboxed<Quat>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__VictimPlayerViewRotation_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__VictimPlayerViewRotation_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<Quat>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe System.IntPtr _AttackerPlayerHandle_k__BackingField
    {
      get
      {
        return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__AttackerPlayerHandle_k__BackingField));
      }
      [param: In] set
      {
        *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__AttackerPlayerHandle_k__BackingField)) = value;
      }
    }

    public unsafe Nullable_Unboxed<Vec3f> _AttackerPlayerPosition_k__BackingField
    {
      get
      {
        return *(Nullable_Unboxed<Vec3f>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__AttackerPlayerPosition_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__AttackerPlayerPosition_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<Vec3f>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<Quat> _AttackerPlayerViewRotation_k__BackingField
    {
      get
      {
        return *(Nullable_Unboxed<Quat>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__AttackerPlayerViewRotation_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__AttackerPlayerViewRotation_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<Quat>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool _IsHitscanAttack_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__IsHitscanAttack_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__IsHitscanAttack_k__BackingField)) = value;
      }
    }

    public unsafe bool _HasLineOfSight_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__HasLineOfSight_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__HasLineOfSight_k__BackingField)) = value;
      }
    }

    public unsafe bool _IsCriticalHit_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__IsCriticalHit_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__IsCriticalHit_k__BackingField)) = value;
      }
    }

    public unsafe uint _HitBoneId_DEPRECATED_k__BackingField
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__HitBoneId_DEPRECATED_k__BackingField));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__HitBoneId_DEPRECATED_k__BackingField)) = value;
      }
    }

    public unsafe float _DamageTaken_k__BackingField
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageTaken_k__BackingField));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageTaken_k__BackingField)) = value;
      }
    }

    public unsafe float _HealthRemaining_k__BackingField
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__HealthRemaining_k__BackingField));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__HealthRemaining_k__BackingField)) = value;
      }
    }

    public unsafe AntiCheatCommonPlayerTakeDamageSource _DamageSource_k__BackingField
    {
      get
      {
        return *(AntiCheatCommonPlayerTakeDamageSource*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageSource_k__BackingField));
      }
      [param: In] set
      {
        *(AntiCheatCommonPlayerTakeDamageSource*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageSource_k__BackingField)) = value;
      }
    }

    public unsafe AntiCheatCommonPlayerTakeDamageType _DamageType_k__BackingField
    {
      get
      {
        return *(AntiCheatCommonPlayerTakeDamageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageType_k__BackingField));
      }
      [param: In] set
      {
        *(AntiCheatCommonPlayerTakeDamageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageType_k__BackingField)) = value;
      }
    }

    public unsafe AntiCheatCommonPlayerTakeDamageResult _DamageResult_k__BackingField
    {
      get
      {
        return *(AntiCheatCommonPlayerTakeDamageResult*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageResult_k__BackingField));
      }
      [param: In] set
      {
        *(AntiCheatCommonPlayerTakeDamageResult*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageResult_k__BackingField)) = value;
      }
    }

    public Il2CppSystem.Nullable<LogPlayerUseWeaponData> _PlayerUseWeaponData_k__BackingField
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__PlayerUseWeaponData_k__BackingField);
        return new Il2CppSystem.Nullable<LogPlayerUseWeaponData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<LogPlayerUseWeaponData>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__PlayerUseWeaponData_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<LogPlayerUseWeaponData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe uint _TimeSincePlayerUseWeaponMs_k__BackingField
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__TimeSincePlayerUseWeaponMs_k__BackingField));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__TimeSincePlayerUseWeaponMs_k__BackingField)) = value;
      }
    }

    public unsafe Nullable_Unboxed<Vec3f> _DamagePosition_k__BackingField
    {
      get
      {
        return *(Nullable_Unboxed<Vec3f>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamagePosition_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamagePosition_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<Vec3f>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
