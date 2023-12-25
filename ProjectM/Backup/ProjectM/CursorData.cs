// Decompiled with JetBrains decompiler
// Type: ProjectM.CursorData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class CursorData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Texture;
    private static readonly System.IntPtr NativeFieldInfoPtr_CursorType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Hotspot;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CursorData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CursorData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CursorData()
    {
      Il2CppClassPointerStore<CursorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CursorData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorData>.NativeClassPtr);
      CursorData.NativeFieldInfoPtr_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorData>.NativeClassPtr, nameof (Texture));
      CursorData.NativeFieldInfoPtr_CursorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorData>.NativeClassPtr, nameof (CursorType));
      CursorData.NativeFieldInfoPtr_Hotspot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorData>.NativeClassPtr, nameof (Hotspot));
      CursorData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorData>.NativeClassPtr, 100678180);
    }

    public CursorData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Texture2D Texture
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CursorData.NativeFieldInfoPtr_Texture));
        return pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CursorData.NativeFieldInfoPtr_Texture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CursorType CursorType
    {
      get
      {
        return *(CursorType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CursorData.NativeFieldInfoPtr_CursorType));
      }
      [param: In] set
      {
        *(CursorType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CursorData.NativeFieldInfoPtr_CursorType)) = value;
      }
    }

    public unsafe Vector2 Hotspot
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CursorData.NativeFieldInfoPtr_Hotspot));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CursorData.NativeFieldInfoPtr_Hotspot)) = value;
      }
    }
  }
}
