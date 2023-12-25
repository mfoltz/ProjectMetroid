// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.FadeOutObstaclesComponent
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
namespace ProjectM.Presentation
{
  public class FadeOutObstaclesComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Radius;
    private static readonly IntPtr NativeFieldInfoPtr_MaxHeightDifference;
    private static readonly IntPtr NativeFieldInfoPtr_HeightOffset;
    private static readonly IntPtr NativeFieldInfoPtr_DepthOffset;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112453, XrefRangeEnd = 1112461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(FadeOutObstaclesComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112461, XrefRangeEnd = 1112462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FadeOutObstaclesComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FadeOutObstaclesComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FadeOutObstaclesComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FadeOutObstaclesComponent()
    {
      Il2CppClassPointerStore<FadeOutObstaclesComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (FadeOutObstaclesComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FadeOutObstaclesComponent>.NativeClassPtr);
      FadeOutObstaclesComponent.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeOutObstaclesComponent>.NativeClassPtr, nameof (Radius));
      FadeOutObstaclesComponent.NativeFieldInfoPtr_MaxHeightDifference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeOutObstaclesComponent>.NativeClassPtr, nameof (MaxHeightDifference));
      FadeOutObstaclesComponent.NativeFieldInfoPtr_HeightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeOutObstaclesComponent>.NativeClassPtr, nameof (HeightOffset));
      FadeOutObstaclesComponent.NativeFieldInfoPtr_DepthOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeOutObstaclesComponent>.NativeClassPtr, nameof (DepthOffset));
      FadeOutObstaclesComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeOutObstaclesComponent>.NativeClassPtr, 100688070);
      FadeOutObstaclesComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeOutObstaclesComponent>.NativeClassPtr, 100688071);
    }

    public FadeOutObstaclesComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Radius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeOutObstaclesComponent.NativeFieldInfoPtr_Radius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeOutObstaclesComponent.NativeFieldInfoPtr_Radius)) = value;
      }
    }

    public unsafe float MaxHeightDifference
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeOutObstaclesComponent.NativeFieldInfoPtr_MaxHeightDifference));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeOutObstaclesComponent.NativeFieldInfoPtr_MaxHeightDifference)) = value;
      }
    }

    public unsafe float HeightOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeOutObstaclesComponent.NativeFieldInfoPtr_HeightOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeOutObstaclesComponent.NativeFieldInfoPtr_HeightOffset)) = value;
      }
    }

    public unsafe float DepthOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeOutObstaclesComponent.NativeFieldInfoPtr_DepthOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeOutObstaclesComponent.NativeFieldInfoPtr_DepthOffset)) = value;
      }
    }
  }
}
