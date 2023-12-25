// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.Quat
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Quat
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__w_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__x_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__y_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__z_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_w_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_w_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_x_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_y_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_z_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_z_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_QuatInternal_0;
    [FieldOffset(0)]
    public float _w_k__BackingField;
    [FieldOffset(4)]
    public float _x_k__BackingField;
    [FieldOffset(8)]
    public float _y_k__BackingField;
    [FieldOffset(12)]
    public float _z_k__BackingField;

    public unsafe float w
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 538356, RefRangeEnd = 538358, XrefRangeStart = 538356, XrefRangeEnd = 538358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Quat.NativeMethodInfoPtr_get_w_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(32), CachedScanResults(RefRangeStart = 195710, RefRangeEnd = 195742, XrefRangeStart = 195710, XrefRangeEnd = 195742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Quat.NativeMethodInfoPtr_set_w_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float x
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Quat.NativeMethodInfoPtr_get_x_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 195834, RefRangeEnd = 195854, XrefRangeStart = 195834, XrefRangeEnd = 195854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Quat.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float y
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Quat.NativeMethodInfoPtr_get_y_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 195993, RefRangeEnd = 196007, XrefRangeStart = 195993, XrefRangeEnd = 196007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Quat.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float z
    {
      [CallerCount(21), CachedScanResults(RefRangeStart = 322188, RefRangeEnd = 322209, XrefRangeStart = 322188, XrefRangeEnd = 322209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Quat.NativeMethodInfoPtr_get_z_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 196182, RefRangeEnd = 196202, XrefRangeStart = 196182, XrefRangeEnd = 196202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Quat.NativeMethodInfoPtr_set_z_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    public unsafe void Set(ref QuatInternal other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Quat.NativeMethodInfoPtr_Set_Internal_Void_byref_QuatInternal_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Quat()
    {
      Il2CppClassPointerStore<Quat>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (Quat));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quat>.NativeClassPtr);
      Quat.NativeFieldInfoPtr__w_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quat>.NativeClassPtr, "<w>k__BackingField");
      Quat.NativeFieldInfoPtr__x_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quat>.NativeClassPtr, "<x>k__BackingField");
      Quat.NativeFieldInfoPtr__y_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quat>.NativeClassPtr, "<y>k__BackingField");
      Quat.NativeFieldInfoPtr__z_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quat>.NativeClassPtr, "<z>k__BackingField");
      Quat.NativeMethodInfoPtr_get_w_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quat>.NativeClassPtr, 100674236);
      Quat.NativeMethodInfoPtr_set_w_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quat>.NativeClassPtr, 100674237);
      Quat.NativeMethodInfoPtr_get_x_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quat>.NativeClassPtr, 100674238);
      Quat.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quat>.NativeClassPtr, 100674239);
      Quat.NativeMethodInfoPtr_get_y_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quat>.NativeClassPtr, 100674240);
      Quat.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quat>.NativeClassPtr, 100674241);
      Quat.NativeMethodInfoPtr_get_z_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quat>.NativeClassPtr, 100674242);
      Quat.NativeMethodInfoPtr_set_z_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quat>.NativeClassPtr, 100674243);
      Quat.NativeMethodInfoPtr_Set_Internal_Void_byref_QuatInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quat>.NativeClassPtr, 100674244);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Quat>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
