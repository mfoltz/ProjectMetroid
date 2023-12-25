// Decompiled with JetBrains decompiler
// Type: ProjectM.HorseBehaviourComponent
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
  public class HorseBehaviourComponent : BehaviourTreeComponent
  {
    private static readonly IntPtr NativeFieldInfoPtr_FleeDistanceMin;
    private static readonly IntPtr NativeFieldInfoPtr_FleeDistanceMax;
    private static readonly IntPtr NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_Idle_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_Flee_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1328425, XrefRangeEnd = 1328449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe BehaviourTreeNodeAuthoring BuildTree(
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HorseBehaviourComponent.NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1328473, RefRangeEnd = 1328474, XrefRangeStart = 1328449, XrefRangeEnd = 1328473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(HorseBehaviourComponent.NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1328514, RefRangeEnd = 1328515, XrefRangeStart = 1328474, XrefRangeEnd = 1328514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Idle()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(HorseBehaviourComponent.NativeMethodInfoPtr_Idle_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1328613, RefRangeEnd = 1328614, XrefRangeStart = 1328515, XrefRangeEnd = 1328613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Flee()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(HorseBehaviourComponent.NativeMethodInfoPtr_Flee_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(HorseBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HorseBehaviourComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HorseBehaviourComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HorseBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HorseBehaviourComponent()
    {
      Il2CppClassPointerStore<HorseBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM", nameof (HorseBehaviourComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HorseBehaviourComponent>.NativeClassPtr);
      HorseBehaviourComponent.NativeFieldInfoPtr_FleeDistanceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorseBehaviourComponent>.NativeClassPtr, nameof (FleeDistanceMin));
      HorseBehaviourComponent.NativeFieldInfoPtr_FleeDistanceMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorseBehaviourComponent>.NativeClassPtr, nameof (FleeDistanceMax));
      HorseBehaviourComponent.NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseBehaviourComponent>.NativeClassPtr, 100663737);
      HorseBehaviourComponent.NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseBehaviourComponent>.NativeClassPtr, 100663738);
      HorseBehaviourComponent.NativeMethodInfoPtr_Idle_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseBehaviourComponent>.NativeClassPtr, 100663739);
      HorseBehaviourComponent.NativeMethodInfoPtr_Flee_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseBehaviourComponent>.NativeClassPtr, 100663740);
      HorseBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseBehaviourComponent>.NativeClassPtr, 100663741);
      HorseBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorseBehaviourComponent>.NativeClassPtr, 100663742);
    }

    public HorseBehaviourComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float FleeDistanceMin
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HorseBehaviourComponent.NativeFieldInfoPtr_FleeDistanceMin));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HorseBehaviourComponent.NativeFieldInfoPtr_FleeDistanceMin)) = value;
      }
    }

    public unsafe float FleeDistanceMax
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HorseBehaviourComponent.NativeFieldInfoPtr_FleeDistanceMax));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HorseBehaviourComponent.NativeFieldInfoPtr_FleeDistanceMax)) = value;
      }
    }
  }
}
