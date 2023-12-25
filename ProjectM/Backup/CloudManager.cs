// Decompiled with JetBrains decompiler
// Type: CloudManager
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CloudManager : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_CLOUDMANAGER_ASSET_PATH;
  private static readonly IntPtr NativeFieldInfoPtr_CLOUDMANAGER_RESOURCES_PATH;
  private static readonly IntPtr NativeFieldInfoPtr_CloudTextures;
  private static readonly IntPtr NativeFieldInfoPtr_MovingCloudTexture;
  private static readonly IntPtr NativeFieldInfoPtr_CloudLayer1Size;
  private static readonly IntPtr NativeFieldInfoPtr_CloudLayer2Size;
  private static readonly IntPtr NativeFieldInfoPtr_EnableInEditor;
  private static readonly IntPtr NativeFieldInfoPtr_WindSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_Cloudiness;
  private static readonly IntPtr NativeFieldInfoPtr__MagentaTexture;
  private static readonly IntPtr NativeMethodInfoPtr_GetMagentaTexture_Private_Texture2D_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckResourcesAndLogErrors_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTextureAndMagentaIfMissing_Public_Texture2D_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture2D_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMovingCloudTexture_Public_Texture2D_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 912439, RefRangeEnd = 912442, XrefRangeStart = 912419, XrefRangeEnd = 912439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture2D GetMagentaTexture()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CloudManager.NativeMethodInfoPtr_GetMagentaTexture_Private_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912442, XrefRangeEnd = 912457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckResourcesAndLogErrors()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CloudManager.NativeMethodInfoPtr_CheckResourcesAndLogErrors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 912463, RefRangeEnd = 912467, XrefRangeStart = 912457, XrefRangeEnd = 912463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture2D GetTextureAndMagentaIfMissing(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = (IntPtr) &index;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CloudManager.NativeMethodInfoPtr_GetTextureAndMagentaIfMissing_Public_Texture2D_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 912471, RefRangeEnd = 912474, XrefRangeStart = 912467, XrefRangeEnd = 912471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture2D GetTexture(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = (IntPtr) &index;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CloudManager.NativeMethodInfoPtr_GetTexture_Public_Texture2D_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912474, XrefRangeEnd = 912479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture2D GetMovingCloudTexture()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CloudManager.NativeMethodInfoPtr_GetMovingCloudTexture_Public_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912479, XrefRangeEnd = 912484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CloudManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloudManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CloudManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CloudManager()
  {
    Il2CppClassPointerStore<CloudManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (CloudManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloudManager>.NativeClassPtr);
    CloudManager.NativeFieldInfoPtr_CLOUDMANAGER_ASSET_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudManager>.NativeClassPtr, nameof (CLOUDMANAGER_ASSET_PATH));
    CloudManager.NativeFieldInfoPtr_CLOUDMANAGER_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudManager>.NativeClassPtr, nameof (CLOUDMANAGER_RESOURCES_PATH));
    CloudManager.NativeFieldInfoPtr_CloudTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudManager>.NativeClassPtr, nameof (CloudTextures));
    CloudManager.NativeFieldInfoPtr_MovingCloudTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudManager>.NativeClassPtr, nameof (MovingCloudTexture));
    CloudManager.NativeFieldInfoPtr_CloudLayer1Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudManager>.NativeClassPtr, nameof (CloudLayer1Size));
    CloudManager.NativeFieldInfoPtr_CloudLayer2Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudManager>.NativeClassPtr, nameof (CloudLayer2Size));
    CloudManager.NativeFieldInfoPtr_EnableInEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudManager>.NativeClassPtr, nameof (EnableInEditor));
    CloudManager.NativeFieldInfoPtr_WindSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudManager>.NativeClassPtr, nameof (WindSpeed));
    CloudManager.NativeFieldInfoPtr_Cloudiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudManager>.NativeClassPtr, nameof (Cloudiness));
    CloudManager.NativeFieldInfoPtr__MagentaTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudManager>.NativeClassPtr, nameof (_MagentaTexture));
    CloudManager.NativeMethodInfoPtr_GetMagentaTexture_Private_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudManager>.NativeClassPtr, 100663398);
    CloudManager.NativeMethodInfoPtr_CheckResourcesAndLogErrors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudManager>.NativeClassPtr, 100663399);
    CloudManager.NativeMethodInfoPtr_GetTextureAndMagentaIfMissing_Public_Texture2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudManager>.NativeClassPtr, 100663400);
    CloudManager.NativeMethodInfoPtr_GetTexture_Public_Texture2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudManager>.NativeClassPtr, 100663401);
    CloudManager.NativeMethodInfoPtr_GetMovingCloudTexture_Public_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudManager>.NativeClassPtr, 100663402);
    CloudManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudManager>.NativeClassPtr, 100663403);
  }

  public CloudManager(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string CLOUDMANAGER_ASSET_PATH
  {
    get
    {
      IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(CloudManager.NativeFieldInfoPtr_CLOUDMANAGER_ASSET_PATH, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CloudManager.NativeFieldInfoPtr_CLOUDMANAGER_ASSET_PATH, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string CLOUDMANAGER_RESOURCES_PATH
  {
    get
    {
      IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(CloudManager.NativeFieldInfoPtr_CLOUDMANAGER_RESOURCES_PATH, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CloudManager.NativeFieldInfoPtr_CLOUDMANAGER_RESOURCES_PATH, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppReferenceArray<Texture2D> CloudTextures
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudManager.NativeFieldInfoPtr_CloudTextures));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Texture2D>) null : new Il2CppReferenceArray<Texture2D>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CloudManager.NativeFieldInfoPtr_CloudTextures), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2D MovingCloudTexture
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudManager.NativeFieldInfoPtr_MovingCloudTexture));
      return pointer == IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CloudManager.NativeFieldInfoPtr_MovingCloudTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float CloudLayer1Size
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudManager.NativeFieldInfoPtr_CloudLayer1Size));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudManager.NativeFieldInfoPtr_CloudLayer1Size)) = value;
    }
  }

  public unsafe float CloudLayer2Size
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudManager.NativeFieldInfoPtr_CloudLayer2Size));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudManager.NativeFieldInfoPtr_CloudLayer2Size)) = value;
    }
  }

  public unsafe bool EnableInEditor
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudManager.NativeFieldInfoPtr_EnableInEditor));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudManager.NativeFieldInfoPtr_EnableInEditor)) = value;
    }
  }

  public unsafe Vector2 WindSpeed
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudManager.NativeFieldInfoPtr_WindSpeed));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudManager.NativeFieldInfoPtr_WindSpeed)) = value;
    }
  }

  public unsafe float Cloudiness
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudManager.NativeFieldInfoPtr_Cloudiness));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudManager.NativeFieldInfoPtr_Cloudiness)) = value;
    }
  }

  public unsafe Texture2D _MagentaTexture
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudManager.NativeFieldInfoPtr__MagentaTexture));
      return pointer == IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CloudManager.NativeFieldInfoPtr__MagentaTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
