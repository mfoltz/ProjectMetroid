// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerTickOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LogPlayerTickOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PlayerHandle_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlayerPosition_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlayerViewRotation_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsPlayerViewZoomed_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlayerHealth_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlayerMovementState_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerHandle_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerPosition_Public_get_Nullable_Unboxed_1_Vec3f_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerViewRotation_Public_get_Nullable_Unboxed_1_Quat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPlayerViewZoomed_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerHealth_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerHealth_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerMovementState_Public_get_AntiCheatCommonPlayerMovementState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerMovementState_Public_set_Void_AntiCheatCommonPlayerMovementState_0;
    [FieldOffset(0)]
    public System.IntPtr _PlayerHandle_k__BackingField;
    [FieldOffset(8)]
    public Nullable_Unboxed<Vec3f> _PlayerPosition_k__BackingField;
    [FieldOffset(24)]
    public Nullable_Unboxed<Quat> _PlayerViewRotation_k__BackingField;
    [FieldOffset(44)]
    public bool _IsPlayerViewZoomed_k__BackingField;
    [FieldOffset(48)]
    public float _PlayerHealth_k__BackingField;
    [FieldOffset(52)]
    public AntiCheatCommonPlayerMovementState _PlayerMovementState_k__BackingField;

    public unsafe System.IntPtr PlayerHandle
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerHandle_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Vec3f> PlayerPosition
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerPosition_Public_get_Nullable_Unboxed_1_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<Vec3f>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Quat> PlayerViewRotation
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerViewRotation_Public_get_Nullable_Unboxed_1_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<Quat>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsPlayerViewZoomed
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_get_IsPlayerViewZoomed_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float PlayerHealth
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerHealth_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 315497, RefRangeEnd = 315498, XrefRangeStart = 315497, XrefRangeEnd = 315498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerHealth_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonPlayerMovementState PlayerMovementState
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 20693, RefRangeEnd = 20694, XrefRangeStart = 20693, XrefRangeEnd = 20694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerMovementState_Public_get_AntiCheatCommonPlayerMovementState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AntiCheatCommonPlayerMovementState*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerMovementState_Public_set_Void_AntiCheatCommonPlayerMovementState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static LogPlayerTickOptions()
    {
      Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerTickOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr);
      LogPlayerTickOptions.NativeFieldInfoPtr__PlayerHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, "<PlayerHandle>k__BackingField");
      LogPlayerTickOptions.NativeFieldInfoPtr__PlayerPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, "<PlayerPosition>k__BackingField");
      LogPlayerTickOptions.NativeFieldInfoPtr__PlayerViewRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, "<PlayerViewRotation>k__BackingField");
      LogPlayerTickOptions.NativeFieldInfoPtr__IsPlayerViewZoomed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, "<IsPlayerViewZoomed>k__BackingField");
      LogPlayerTickOptions.NativeFieldInfoPtr__PlayerHealth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, "<PlayerHealth>k__BackingField");
      LogPlayerTickOptions.NativeFieldInfoPtr__PlayerMovementState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, "<PlayerMovementState>k__BackingField");
      LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100674100);
      LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100674101);
      LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerPosition_Public_get_Nullable_Unboxed_1_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100674102);
      LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100674103);
      LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerViewRotation_Public_get_Nullable_Unboxed_1_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100674104);
      LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100674105);
      LogPlayerTickOptions.NativeMethodInfoPtr_get_IsPlayerViewZoomed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100674106);
      LogPlayerTickOptions.NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100674107);
      LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100674108);
      LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerHealth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100674109);
      LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerMovementState_Public_get_AntiCheatCommonPlayerMovementState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100674110);
      LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerMovementState_Public_set_Void_AntiCheatCommonPlayerMovementState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100674111);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
