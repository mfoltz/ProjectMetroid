// Decompiled with JetBrains decompiler
// Type: Unity.Physics.Extensions.MousePickBehaviour
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
namespace Unity.Physics.Extensions
{
  public class MousePickBehaviour : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_IgnoreTriggers;
    private static readonly IntPtr NativeMethodInfoPtr_Unity_Entities_IConvertGameObjectToEntity_Convert_Private_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926163, XrefRangeEnd = 926166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Unity_Entities_IConvertGameObjectToEntity_Convert(
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
      IL2CPP.il2cpp_runtime_invoke(MousePickBehaviour.NativeMethodInfoPtr_Unity_Entities_IConvertGameObjectToEntity_Convert_Private_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 631690, RefRangeEnd = 631694, XrefRangeStart = 631690, XrefRangeEnd = 631694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MousePickBehaviour()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MousePickBehaviour>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MousePickBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MousePickBehaviour()
    {
      Il2CppClassPointerStore<MousePickBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Physics.Extensions", nameof (MousePickBehaviour));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MousePickBehaviour>.NativeClassPtr);
      MousePickBehaviour.NativeFieldInfoPtr_IgnoreTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickBehaviour>.NativeClassPtr, nameof (IgnoreTriggers));
      MousePickBehaviour.NativeMethodInfoPtr_Unity_Entities_IConvertGameObjectToEntity_Convert_Private_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePickBehaviour>.NativeClassPtr, 100663993);
      MousePickBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePickBehaviour>.NativeClassPtr, 100663994);
    }

    public MousePickBehaviour(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool IgnoreTriggers
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MousePickBehaviour.NativeFieldInfoPtr_IgnoreTriggers));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MousePickBehaviour.NativeFieldInfoPtr_IgnoreTriggers)) = value;
      }
    }
  }
}
