// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.QuatInternal
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
  public struct QuatInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_w;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_x;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_y;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_z;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_w_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_w_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_x_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_y_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_z_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_z_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Quat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_Quat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_Quat_0;
    [FieldOffset(0)]
    public float m_w;
    [FieldOffset(4)]
    public float m_x;
    [FieldOffset(8)]
    public float m_y;
    [FieldOffset(12)]
    public float m_z;

    public unsafe float w
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 538356, RefRangeEnd = 538358, XrefRangeStart = 538356, XrefRangeEnd = 538358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_get_w_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(32), CachedScanResults(RefRangeStart = 195710, RefRangeEnd = 195742, XrefRangeStart = 195710, XrefRangeEnd = 195742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_set_w_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float x
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_get_x_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 195834, RefRangeEnd = 195854, XrefRangeStart = 195834, XrefRangeEnd = 195854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float y
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_get_y_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 195993, RefRangeEnd = 196007, XrefRangeStart = 195993, XrefRangeEnd = 196007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float z
    {
      [CallerCount(21), CachedScanResults(RefRangeStart = 322188, RefRangeEnd = 322209, XrefRangeStart = 322188, XrefRangeEnd = 322209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_get_z_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 196182, RefRangeEnd = 196202, XrefRangeStart = 196182, XrefRangeEnd = 196202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_set_z_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    public virtual unsafe void Set(ref Quat other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970670, XrefRangeEnd = 970680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Nullable_Unboxed<Quat> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void Get(out Quat output)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref output;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static QuatInternal()
    {
      Il2CppClassPointerStore<QuatInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (QuatInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr);
      QuatInternal.NativeFieldInfoPtr_m_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, nameof (m_w));
      QuatInternal.NativeFieldInfoPtr_m_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, nameof (m_x));
      QuatInternal.NativeFieldInfoPtr_m_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, nameof (m_y));
      QuatInternal.NativeFieldInfoPtr_m_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, nameof (m_z));
      QuatInternal.NativeMethodInfoPtr_get_w_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100674245);
      QuatInternal.NativeMethodInfoPtr_set_w_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100674246);
      QuatInternal.NativeMethodInfoPtr_get_x_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100674247);
      QuatInternal.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100674248);
      QuatInternal.NativeMethodInfoPtr_get_y_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100674249);
      QuatInternal.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100674250);
      QuatInternal.NativeMethodInfoPtr_get_z_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100674251);
      QuatInternal.NativeMethodInfoPtr_set_z_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100674252);
      QuatInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100674253);
      QuatInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100674254);
      QuatInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100674255);
      QuatInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100674256);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
