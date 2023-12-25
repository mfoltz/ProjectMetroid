// Decompiled with JetBrains decompiler
// Type: ProjectM.NullBehaviourComponent
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Behaviours;
using System;

#nullable disable
namespace ProjectM
{
  public class NullBehaviourComponent : BehaviourTreeComponent
  {
    private static readonly IntPtr NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1328859, XrefRangeEnd = 1328869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe BehaviourTreeNodeAuthoring BuildTree(
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), NullBehaviourComponent.NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1328899, RefRangeEnd = 1328900, XrefRangeStart = 1328869, XrefRangeEnd = 1328899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(NullBehaviourComponent.NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(NullBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NullBehaviourComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullBehaviourComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NullBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NullBehaviourComponent()
    {
      Il2CppClassPointerStore<NullBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM", nameof (NullBehaviourComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullBehaviourComponent>.NativeClassPtr);
      NullBehaviourComponent.NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullBehaviourComponent>.NativeClassPtr, 100663745);
      NullBehaviourComponent.NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullBehaviourComponent>.NativeClassPtr, 100663746);
      NullBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullBehaviourComponent>.NativeClassPtr, 100663747);
      NullBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullBehaviourComponent>.NativeClassPtr, 100663748);
    }

    public NullBehaviourComponent(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
