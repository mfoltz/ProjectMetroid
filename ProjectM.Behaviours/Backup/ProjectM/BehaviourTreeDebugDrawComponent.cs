// Decompiled with JetBrains decompiler
// Type: ProjectM.BehaviourTreeDebugDrawComponent
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

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
  public class BehaviourTreeDebugDrawComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DrawPos0;
    private static readonly IntPtr NativeFieldInfoPtr_DrawPos1;
    private static readonly IntPtr NativeFieldInfoPtr_DrawPos2;
    private static readonly IntPtr NativeFieldInfoPtr_DrawPos3;
    private static readonly IntPtr NativeFieldInfoPtr_DrawPos4;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335733, XrefRangeEnd = 1335736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeDebugDrawComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeDebugDrawComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeDebugDrawComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BehaviourTreeDebugDrawComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeDebugDrawComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BehaviourTreeDebugDrawComponent()
    {
      Il2CppClassPointerStore<BehaviourTreeDebugDrawComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM", nameof (BehaviourTreeDebugDrawComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeDebugDrawComponent>.NativeClassPtr);
      BehaviourTreeDebugDrawComponent.NativeFieldInfoPtr_DrawPos0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugDrawComponent>.NativeClassPtr, nameof (DrawPos0));
      BehaviourTreeDebugDrawComponent.NativeFieldInfoPtr_DrawPos1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugDrawComponent>.NativeClassPtr, nameof (DrawPos1));
      BehaviourTreeDebugDrawComponent.NativeFieldInfoPtr_DrawPos2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugDrawComponent>.NativeClassPtr, nameof (DrawPos2));
      BehaviourTreeDebugDrawComponent.NativeFieldInfoPtr_DrawPos3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugDrawComponent>.NativeClassPtr, nameof (DrawPos3));
      BehaviourTreeDebugDrawComponent.NativeFieldInfoPtr_DrawPos4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugDrawComponent>.NativeClassPtr, nameof (DrawPos4));
      BehaviourTreeDebugDrawComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeDebugDrawComponent>.NativeClassPtr, 100664394);
      BehaviourTreeDebugDrawComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeDebugDrawComponent>.NativeClassPtr, 100664395);
      BehaviourTreeDebugDrawComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeDebugDrawComponent>.NativeClassPtr, 100664396);
    }

    public BehaviourTreeDebugDrawComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool DrawPos0
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeDebugDrawComponent.NativeFieldInfoPtr_DrawPos0));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeDebugDrawComponent.NativeFieldInfoPtr_DrawPos0)) = value;
      }
    }

    public unsafe bool DrawPos1
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeDebugDrawComponent.NativeFieldInfoPtr_DrawPos1));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeDebugDrawComponent.NativeFieldInfoPtr_DrawPos1)) = value;
      }
    }

    public unsafe bool DrawPos2
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeDebugDrawComponent.NativeFieldInfoPtr_DrawPos2));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeDebugDrawComponent.NativeFieldInfoPtr_DrawPos2)) = value;
      }
    }

    public unsafe bool DrawPos3
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeDebugDrawComponent.NativeFieldInfoPtr_DrawPos3));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeDebugDrawComponent.NativeFieldInfoPtr_DrawPos3)) = value;
      }
    }

    public unsafe bool DrawPos4
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeDebugDrawComponent.NativeFieldInfoPtr_DrawPos4));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeDebugDrawComponent.NativeFieldInfoPtr_DrawPos4)) = value;
      }
    }
  }
}
