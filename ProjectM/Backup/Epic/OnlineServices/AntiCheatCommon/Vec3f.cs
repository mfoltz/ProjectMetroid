// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.Vec3f
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
  public struct Vec3f
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__x_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__y_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__z_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_x_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_y_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_z_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_z_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_Vec3fInternal_0;
    [FieldOffset(0)]
    public float _x_k__BackingField;
    [FieldOffset(4)]
    public float _y_k__BackingField;
    [FieldOffset(8)]
    public float _z_k__BackingField;

    public unsafe float x
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 538356, RefRangeEnd = 538358, XrefRangeStart = 538356, XrefRangeEnd = 538358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Vec3f.NativeMethodInfoPtr_get_x_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(32), CachedScanResults(RefRangeStart = 195710, RefRangeEnd = 195742, XrefRangeStart = 195710, XrefRangeEnd = 195742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Vec3f.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float y
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Vec3f.NativeMethodInfoPtr_get_y_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 195834, RefRangeEnd = 195854, XrefRangeStart = 195834, XrefRangeEnd = 195854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Vec3f.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float z
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Vec3f.NativeMethodInfoPtr_get_z_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 195993, RefRangeEnd = 196007, XrefRangeStart = 195993, XrefRangeEnd = 196007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Vec3f.NativeMethodInfoPtr_set_z_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 853759, RefRangeEnd = 853760, XrefRangeStart = 853759, XrefRangeEnd = 853760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref Vec3fInternal other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Vec3f.NativeMethodInfoPtr_Set_Internal_Void_byref_Vec3fInternal_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Vec3f()
    {
      Il2CppClassPointerStore<Vec3f>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (Vec3f));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vec3f>.NativeClassPtr);
      Vec3f.NativeFieldInfoPtr__x_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vec3f>.NativeClassPtr, "<x>k__BackingField");
      Vec3f.NativeFieldInfoPtr__y_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vec3f>.NativeClassPtr, "<y>k__BackingField");
      Vec3f.NativeFieldInfoPtr__z_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vec3f>.NativeClassPtr, "<z>k__BackingField");
      Vec3f.NativeMethodInfoPtr_get_x_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3f>.NativeClassPtr, 100674303);
      Vec3f.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3f>.NativeClassPtr, 100674304);
      Vec3f.NativeMethodInfoPtr_get_y_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3f>.NativeClassPtr, 100674305);
      Vec3f.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3f>.NativeClassPtr, 100674306);
      Vec3f.NativeMethodInfoPtr_get_z_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3f>.NativeClassPtr, 100674307);
      Vec3f.NativeMethodInfoPtr_set_z_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3f>.NativeClassPtr, 100674308);
      Vec3f.NativeMethodInfoPtr_Set_Internal_Void_byref_Vec3fInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3f>.NativeClassPtr, 100674309);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vec3f>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
