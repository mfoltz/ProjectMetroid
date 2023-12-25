// Decompiled with JetBrains decompiler
// Type: ProjectM.MinerBehaviourComponent
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
  public class MinerBehaviourComponent : GenericEnemyBehaviourComponent
  {
    private static readonly IntPtr NativeFieldInfoPtr_ResourceNodeRange;
    private static readonly IntPtr NativeFieldInfoPtr_ResourceNodeDistance;
    private static readonly IntPtr NativeMethodInfoPtr_Idle_Protected_Virtual_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1328614, XrefRangeEnd = 1328858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe BehaviourTreeNodeAuthoring Idle()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MinerBehaviourComponent.NativeMethodInfoPtr_Idle_Protected_Virtual_BehaviourTreeNodeAuthoring_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1328858, XrefRangeEnd = 1328859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MinerBehaviourComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinerBehaviourComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MinerBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MinerBehaviourComponent()
    {
      Il2CppClassPointerStore<MinerBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM", nameof (MinerBehaviourComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinerBehaviourComponent>.NativeClassPtr);
      MinerBehaviourComponent.NativeFieldInfoPtr_ResourceNodeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinerBehaviourComponent>.NativeClassPtr, nameof (ResourceNodeRange));
      MinerBehaviourComponent.NativeFieldInfoPtr_ResourceNodeDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinerBehaviourComponent>.NativeClassPtr, nameof (ResourceNodeDistance));
      MinerBehaviourComponent.NativeMethodInfoPtr_Idle_Protected_Virtual_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinerBehaviourComponent>.NativeClassPtr, 100663743);
      MinerBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinerBehaviourComponent>.NativeClassPtr, 100663744);
    }

    public MinerBehaviourComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float ResourceNodeRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinerBehaviourComponent.NativeFieldInfoPtr_ResourceNodeRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinerBehaviourComponent.NativeFieldInfoPtr_ResourceNodeRange)) = value;
      }
    }

    public unsafe float ResourceNodeDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinerBehaviourComponent.NativeFieldInfoPtr_ResourceNodeDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinerBehaviourComponent.NativeFieldInfoPtr_ResourceNodeDistance)) = value;
      }
    }
  }
}
