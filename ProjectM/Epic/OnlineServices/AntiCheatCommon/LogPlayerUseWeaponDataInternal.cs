// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerUseWeaponDataInternal
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
  public struct LogPlayerUseWeaponDataInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerViewRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IsPlayerViewZoomed;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IsMeleeAttack;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_WeaponName;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerHandle_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerPosition_Public_get_Nullable_Unboxed_1_Vec3f_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerViewRotation_Public_get_Nullable_Unboxed_1_Quat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPlayerViewZoomed_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsMeleeAttack_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsMeleeAttack_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_WeaponName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_WeaponName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogPlayerUseWeaponData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogPlayerUseWeaponData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LogPlayerUseWeaponData_0;
    [FieldOffset(0)]
    public System.IntPtr m_PlayerHandle;
    [FieldOffset(8)]
    public System.IntPtr m_PlayerPosition;
    [FieldOffset(16)]
    public System.IntPtr m_PlayerViewRotation;
    [FieldOffset(24)]
    public int m_IsPlayerViewZoomed;
    [FieldOffset(28)]
    public int m_IsMeleeAttack;
    [FieldOffset(32)]
    public System.IntPtr m_WeaponName;

    public unsafe System.IntPtr PlayerHandle
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_PlayerHandle_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Vec3f> PlayerPosition
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970368, XrefRangeEnd = 970374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_PlayerPosition_Public_get_Nullable_Unboxed_1_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<Vec3f>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970374, XrefRangeEnd = 970380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Quat> PlayerViewRotation
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970380, XrefRangeEnd = 970386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_PlayerViewRotation_Public_get_Nullable_Unboxed_1_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<Quat>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970386, XrefRangeEnd = 970392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsPlayerViewZoomed
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970392, XrefRangeEnd = 970396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_IsPlayerViewZoomed_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970396, XrefRangeEnd = 970400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsMeleeAttack
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970400, XrefRangeEnd = 970404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_IsMeleeAttack_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970404, XrefRangeEnd = 970408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_IsMeleeAttack_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String WeaponName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970408, XrefRangeEnd = 970412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_WeaponName_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970412, XrefRangeEnd = 970416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_WeaponName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970416, XrefRangeEnd = 970440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref LogPlayerUseWeaponData other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogPlayerUseWeaponData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970440, XrefRangeEnd = 970478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<LogPlayerUseWeaponData> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogPlayerUseWeaponData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970478, XrefRangeEnd = 970485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970485, XrefRangeEnd = 970486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out LogPlayerUseWeaponData output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LogPlayerUseWeaponData_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref LogPlayerUseWeaponData local = ref output;
      System.IntPtr pointer = zero;
      LogPlayerUseWeaponData playerUseWeaponData = pointer == System.IntPtr.Zero ? (LogPlayerUseWeaponData) null : new LogPlayerUseWeaponData(pointer);
      local = playerUseWeaponData;
    }

    static LogPlayerUseWeaponDataInternal()
    {
      Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerUseWeaponDataInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr);
      LogPlayerUseWeaponDataInternal.NativeFieldInfoPtr_m_PlayerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, nameof (m_PlayerHandle));
      LogPlayerUseWeaponDataInternal.NativeFieldInfoPtr_m_PlayerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, nameof (m_PlayerPosition));
      LogPlayerUseWeaponDataInternal.NativeFieldInfoPtr_m_PlayerViewRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, nameof (m_PlayerViewRotation));
      LogPlayerUseWeaponDataInternal.NativeFieldInfoPtr_m_IsPlayerViewZoomed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, nameof (m_IsPlayerViewZoomed));
      LogPlayerUseWeaponDataInternal.NativeFieldInfoPtr_m_IsMeleeAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, nameof (m_IsMeleeAttack));
      LogPlayerUseWeaponDataInternal.NativeFieldInfoPtr_m_WeaponName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, nameof (m_WeaponName));
      LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_PlayerHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100674149);
      LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100674150);
      LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_PlayerPosition_Public_get_Nullable_Unboxed_1_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100674151);
      LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100674152);
      LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_PlayerViewRotation_Public_get_Nullable_Unboxed_1_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100674153);
      LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100674154);
      LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_IsPlayerViewZoomed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100674155);
      LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100674156);
      LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_IsMeleeAttack_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100674157);
      LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_IsMeleeAttack_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100674158);
      LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_WeaponName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100674159);
      LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_WeaponName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100674160);
      LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogPlayerUseWeaponData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100674161);
      LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogPlayerUseWeaponData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100674162);
      LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100674163);
      LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LogPlayerUseWeaponData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100674164);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
