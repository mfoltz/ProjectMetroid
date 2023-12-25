// Decompiled with JetBrains decompiler
// Type: ProjectM.CheckOnScreenComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class CheckOnScreenComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_PixelOffset;
    private static readonly IntPtr NativeFieldInfoPtr_IgnoreLineOfSight;
    private static readonly IntPtr NativeFieldInfoPtr_MaxDistanceForHudAndFadeOut;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986983, XrefRangeEnd = 986986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CheckOnScreenComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986986, XrefRangeEnd = 986987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CheckOnScreenComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckOnScreenComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CheckOnScreenComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CheckOnScreenComponent()
    {
      Il2CppClassPointerStore<CheckOnScreenComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CheckOnScreenComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckOnScreenComponent>.NativeClassPtr);
      CheckOnScreenComponent.NativeFieldInfoPtr_PixelOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckOnScreenComponent>.NativeClassPtr, nameof (PixelOffset));
      CheckOnScreenComponent.NativeFieldInfoPtr_IgnoreLineOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckOnScreenComponent>.NativeClassPtr, nameof (IgnoreLineOfSight));
      CheckOnScreenComponent.NativeFieldInfoPtr_MaxDistanceForHudAndFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckOnScreenComponent>.NativeClassPtr, nameof (MaxDistanceForHudAndFadeOut));
      CheckOnScreenComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckOnScreenComponent>.NativeClassPtr, 100676132);
      CheckOnScreenComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckOnScreenComponent>.NativeClassPtr, 100676133);
    }

    public CheckOnScreenComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float PixelOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CheckOnScreenComponent.NativeFieldInfoPtr_PixelOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CheckOnScreenComponent.NativeFieldInfoPtr_PixelOffset)) = value;
      }
    }

    public unsafe bool IgnoreLineOfSight
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CheckOnScreenComponent.NativeFieldInfoPtr_IgnoreLineOfSight));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CheckOnScreenComponent.NativeFieldInfoPtr_IgnoreLineOfSight)) = value;
      }
    }

    public unsafe float MaxDistanceForHudAndFadeOut
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CheckOnScreenComponent.NativeFieldInfoPtr_MaxDistanceForHudAndFadeOut));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CheckOnScreenComponent.NativeFieldInfoPtr_MaxDistanceForHudAndFadeOut)) = value;
      }
    }
  }
}
