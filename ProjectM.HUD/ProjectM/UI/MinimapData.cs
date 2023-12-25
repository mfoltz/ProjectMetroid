// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MinimapData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class MinimapData : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Texture;
    private static readonly System.IntPtr NativeFieldInfoPtr_Zoom;
    private static readonly System.IntPtr NativeFieldInfoPtr_SmallMinimapRectangleSizeInPixels;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MinimapData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinimapData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MinimapData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MinimapData()
    {
      Il2CppClassPointerStore<MinimapData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MinimapData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinimapData>.NativeClassPtr);
      MinimapData.NativeFieldInfoPtr_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapData>.NativeClassPtr, nameof (Texture));
      MinimapData.NativeFieldInfoPtr_Zoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapData>.NativeClassPtr, nameof (Zoom));
      MinimapData.NativeFieldInfoPtr_SmallMinimapRectangleSizeInPixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapData>.NativeClassPtr, nameof (SmallMinimapRectangleSizeInPixels));
      MinimapData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimapData>.NativeClassPtr, 100668193);
    }

    public MinimapData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Texture2D Texture
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapData.NativeFieldInfoPtr_Texture));
        return pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinimapData.NativeFieldInfoPtr_Texture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float Zoom
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapData.NativeFieldInfoPtr_Zoom));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapData.NativeFieldInfoPtr_Zoom)) = value;
      }
    }

    public unsafe float SmallMinimapRectangleSizeInPixels
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapData.NativeFieldInfoPtr_SmallMinimapRectangleSizeInPixels));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapData.NativeFieldInfoPtr_SmallMinimapRectangleSizeInPixels)) = value;
      }
    }

    [Serializable]
    public class TextureProjectionData : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Texture;
      private static readonly System.IntPtr NativeFieldInfoPtr_ProjectionMatrix;
      private static readonly System.IntPtr NativeFieldInfoPtr_LogicToGUIProjectionMatrix;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TextureProjectionData()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinimapData.TextureProjectionData>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MinimapData.TextureProjectionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TextureProjectionData()
      {
        Il2CppClassPointerStore<MinimapData.TextureProjectionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MinimapData>.NativeClassPtr, nameof (TextureProjectionData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinimapData.TextureProjectionData>.NativeClassPtr);
        MinimapData.TextureProjectionData.NativeFieldInfoPtr_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapData.TextureProjectionData>.NativeClassPtr, nameof (Texture));
        MinimapData.TextureProjectionData.NativeFieldInfoPtr_ProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapData.TextureProjectionData>.NativeClassPtr, nameof (ProjectionMatrix));
        MinimapData.TextureProjectionData.NativeFieldInfoPtr_LogicToGUIProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapData.TextureProjectionData>.NativeClassPtr, nameof (LogicToGUIProjectionMatrix));
        MinimapData.TextureProjectionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimapData.TextureProjectionData>.NativeClassPtr, 100668194);
      }

      public TextureProjectionData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Texture2D Texture
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapData.TextureProjectionData.NativeFieldInfoPtr_Texture));
          return pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinimapData.TextureProjectionData.NativeFieldInfoPtr_Texture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Matrix4x4 ProjectionMatrix
      {
        get
        {
          return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapData.TextureProjectionData.NativeFieldInfoPtr_ProjectionMatrix));
        }
        [param: In] set
        {
          *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapData.TextureProjectionData.NativeFieldInfoPtr_ProjectionMatrix)) = value;
        }
      }

      public unsafe Matrix4x4 LogicToGUIProjectionMatrix
      {
        get
        {
          return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapData.TextureProjectionData.NativeFieldInfoPtr_LogicToGUIProjectionMatrix));
        }
        [param: In] set
        {
          *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapData.TextureProjectionData.NativeFieldInfoPtr_LogicToGUIProjectionMatrix)) = value;
        }
      }
    }
  }
}
