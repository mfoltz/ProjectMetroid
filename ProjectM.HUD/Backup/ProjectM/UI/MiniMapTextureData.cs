// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MiniMapTextureData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class MiniMapTextureData : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MapTextures;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MiniMapTextureData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiniMapTextureData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MiniMapTextureData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MiniMapTextureData()
    {
      Il2CppClassPointerStore<MiniMapTextureData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MiniMapTextureData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapTextureData>.NativeClassPtr);
      MiniMapTextureData.NativeFieldInfoPtr_MapTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapTextureData>.NativeClassPtr, nameof (MapTextures));
      MiniMapTextureData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapTextureData>.NativeClassPtr, 100668186);
    }

    public MiniMapTextureData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<MiniMapTextureData.TextureData> MapTextures
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapTextureData.NativeFieldInfoPtr_MapTextures));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<MiniMapTextureData.TextureData>) null : new Il2CppReferenceArray<MiniMapTextureData.TextureData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapTextureData.NativeFieldInfoPtr_MapTextures), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class TextureProjectionData : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Texture;
      private static readonly System.IntPtr NativeFieldInfoPtr_ProjectionMatrix;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TextureProjectionData()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiniMapTextureData.TextureProjectionData>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapTextureData.TextureProjectionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TextureProjectionData()
      {
        Il2CppClassPointerStore<MiniMapTextureData.TextureProjectionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapTextureData>.NativeClassPtr, nameof (TextureProjectionData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapTextureData.TextureProjectionData>.NativeClassPtr);
        MiniMapTextureData.TextureProjectionData.NativeFieldInfoPtr_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapTextureData.TextureProjectionData>.NativeClassPtr, nameof (Texture));
        MiniMapTextureData.TextureProjectionData.NativeFieldInfoPtr_ProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapTextureData.TextureProjectionData>.NativeClassPtr, nameof (ProjectionMatrix));
        MiniMapTextureData.TextureProjectionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapTextureData.TextureProjectionData>.NativeClassPtr, 100668187);
      }

      public TextureProjectionData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Texture2D Texture
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapTextureData.TextureProjectionData.NativeFieldInfoPtr_Texture));
          return pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapTextureData.TextureProjectionData.NativeFieldInfoPtr_Texture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Matrix4x4 ProjectionMatrix
      {
        get
        {
          return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapTextureData.TextureProjectionData.NativeFieldInfoPtr_ProjectionMatrix));
        }
        [param: In] set
        {
          *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapTextureData.TextureProjectionData.NativeFieldInfoPtr_ProjectionMatrix)) = value;
        }
      }
    }

    [Serializable]
    public class TextureData : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ProjectionData;
      private static readonly System.IntPtr NativeFieldInfoPtr_MapPath;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TextureData()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiniMapTextureData.TextureData>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapTextureData.TextureData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TextureData()
      {
        Il2CppClassPointerStore<MiniMapTextureData.TextureData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapTextureData>.NativeClassPtr, nameof (TextureData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapTextureData.TextureData>.NativeClassPtr);
        MiniMapTextureData.TextureData.NativeFieldInfoPtr_ProjectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapTextureData.TextureData>.NativeClassPtr, nameof (ProjectionData));
        MiniMapTextureData.TextureData.NativeFieldInfoPtr_MapPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapTextureData.TextureData>.NativeClassPtr, nameof (MapPath));
        MiniMapTextureData.TextureData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapTextureData.TextureData>.NativeClassPtr, 100668188);
      }

      public TextureData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe MiniMapTextureData.TextureProjectionData ProjectionData
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapTextureData.TextureData.NativeFieldInfoPtr_ProjectionData));
          return pointer == System.IntPtr.Zero ? (MiniMapTextureData.TextureProjectionData) null : new MiniMapTextureData.TextureProjectionData(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapTextureData.TextureData.NativeFieldInfoPtr_ProjectionData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe string MapPath
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapTextureData.TextureData.NativeFieldInfoPtr_MapPath)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapTextureData.TextureData.NativeFieldInfoPtr_MapPath), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }
  }
}
