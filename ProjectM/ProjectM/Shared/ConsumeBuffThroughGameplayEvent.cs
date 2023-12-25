// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ConsumeBuffThroughGameplayEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ConsumeBuffThroughGameplayEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffPrefab;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConsumeBuffThroughGameplayEventAuthoring_0;
    [FieldOffset(0)]
    public readonly GameplayEventId EventId;
    [FieldOffset(8)]
    public readonly PrefabGUID BuffPrefab;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118912, XrefRangeEnd = 1118914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConsumeBuffThroughGameplayEvent(ConsumeBuffThroughGameplayEventAuthoring authoring)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) authoring);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConsumeBuffThroughGameplayEvent.NativeMethodInfoPtr__ctor_Public_Void_ConsumeBuffThroughGameplayEventAuthoring_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConsumeBuffThroughGameplayEvent()
    {
      Il2CppClassPointerStore<ConsumeBuffThroughGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Shared", nameof (ConsumeBuffThroughGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsumeBuffThroughGameplayEvent>.NativeClassPtr);
      ConsumeBuffThroughGameplayEvent.NativeFieldInfoPtr_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeBuffThroughGameplayEvent>.NativeClassPtr, nameof (EventId));
      ConsumeBuffThroughGameplayEvent.NativeFieldInfoPtr_BuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeBuffThroughGameplayEvent>.NativeClassPtr, nameof (BuffPrefab));
      ConsumeBuffThroughGameplayEvent.NativeMethodInfoPtr__ctor_Public_Void_ConsumeBuffThroughGameplayEventAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeBuffThroughGameplayEvent>.NativeClassPtr, 100688747);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConsumeBuffThroughGameplayEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
