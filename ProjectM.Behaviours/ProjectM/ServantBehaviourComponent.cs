// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantBehaviourComponent
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Behaviours;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class ServantBehaviourComponent : BehaviourTreeComponent
  {
    private static readonly IntPtr NativeFieldInfoPtr_MinDestinationWaitTime;
    private static readonly IntPtr NativeFieldInfoPtr_MaxDestinationWaitTime;
    private static readonly IntPtr NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_FindWorkstation_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_WalkToWorkstation_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_TeleportToWorkstation_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1328900, XrefRangeEnd = 1328927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe BehaviourTreeNodeAuthoring BuildTree(
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantBehaviourComponent.NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1328951, RefRangeEnd = 1328952, XrefRangeStart = 1328927, XrefRangeEnd = 1328951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantBehaviourComponent.NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1329015, RefRangeEnd = 1329016, XrefRangeStart = 1328952, XrefRangeEnd = 1329015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring FindWorkstation()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantBehaviourComponent.NativeMethodInfoPtr_FindWorkstation_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1329142, RefRangeEnd = 1329143, XrefRangeStart = 1329016, XrefRangeEnd = 1329142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring WalkToWorkstation()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantBehaviourComponent.NativeMethodInfoPtr_WalkToWorkstation_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1329193, RefRangeEnd = 1329194, XrefRangeStart = 1329143, XrefRangeEnd = 1329193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring TeleportToWorkstation()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantBehaviourComponent.NativeMethodInfoPtr_TeleportToWorkstation_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantBehaviourComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantBehaviourComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantBehaviourComponent()
    {
      Il2CppClassPointerStore<ServantBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM", nameof (ServantBehaviourComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantBehaviourComponent>.NativeClassPtr);
      ServantBehaviourComponent.NativeFieldInfoPtr_MinDestinationWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantBehaviourComponent>.NativeClassPtr, nameof (MinDestinationWaitTime));
      ServantBehaviourComponent.NativeFieldInfoPtr_MaxDestinationWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantBehaviourComponent>.NativeClassPtr, nameof (MaxDestinationWaitTime));
      ServantBehaviourComponent.NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantBehaviourComponent>.NativeClassPtr, 100663749);
      ServantBehaviourComponent.NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantBehaviourComponent>.NativeClassPtr, 100663750);
      ServantBehaviourComponent.NativeMethodInfoPtr_FindWorkstation_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantBehaviourComponent>.NativeClassPtr, 100663751);
      ServantBehaviourComponent.NativeMethodInfoPtr_WalkToWorkstation_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantBehaviourComponent>.NativeClassPtr, 100663752);
      ServantBehaviourComponent.NativeMethodInfoPtr_TeleportToWorkstation_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantBehaviourComponent>.NativeClassPtr, 100663753);
      ServantBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantBehaviourComponent>.NativeClassPtr, 100663754);
      ServantBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantBehaviourComponent>.NativeClassPtr, 100663755);
    }

    public ServantBehaviourComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float MinDestinationWaitTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantBehaviourComponent.NativeFieldInfoPtr_MinDestinationWaitTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantBehaviourComponent.NativeFieldInfoPtr_MinDestinationWaitTime)) = value;
      }
    }

    public unsafe float MaxDestinationWaitTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantBehaviourComponent.NativeFieldInfoPtr_MaxDestinationWaitTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantBehaviourComponent.NativeFieldInfoPtr_MaxDestinationWaitTime)) = value;
      }
    }
  }
}
