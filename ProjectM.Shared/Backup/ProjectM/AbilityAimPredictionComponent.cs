// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityAimPredictionComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

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
  public class AbilityAimPredictionComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_AimPredictionFactor;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724612, XrefRangeEnd = 724615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AbilityAimPredictionComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 724616, RefRangeEnd = 724620, XrefRangeStart = 724615, XrefRangeEnd = 724616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityAimPredictionComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityAimPredictionComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityAimPredictionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityAimPredictionComponent()
    {
      Il2CppClassPointerStore<AbilityAimPredictionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityAimPredictionComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityAimPredictionComponent>.NativeClassPtr);
      AbilityAimPredictionComponent.NativeFieldInfoPtr_AimPredictionFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAimPredictionComponent>.NativeClassPtr, nameof (AimPredictionFactor));
      AbilityAimPredictionComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAimPredictionComponent>.NativeClassPtr, 100664084);
      AbilityAimPredictionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAimPredictionComponent>.NativeClassPtr, 100664085);
    }

    public AbilityAimPredictionComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float AimPredictionFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityAimPredictionComponent.NativeFieldInfoPtr_AimPredictionFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityAimPredictionComponent.NativeFieldInfoPtr_AimPredictionFactor)) = value;
      }
    }
  }
}
