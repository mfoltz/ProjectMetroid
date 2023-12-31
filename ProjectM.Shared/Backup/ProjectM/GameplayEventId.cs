// Decompiled with JetBrains decompiler
// Type: ProjectM.GameplayEventId
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct GameplayEventId
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventType;
    private static readonly System.IntPtr NativeFieldInfoPtr_EventId;
    private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Boolean_GameplayEventId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;
    [FieldOffset(0)]
    public GameplayEventType GameplayEventType;
    [FieldOffset(4)]
    public int EventId;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 747839, RefRangeEnd = 747841, XrefRangeStart = 747839, XrefRangeEnd = 747839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Compare(GameplayEventId other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayEventId.NativeMethodInfoPtr_Compare_Public_Boolean_GameplayEventId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 747841, RefRangeEnd = 747845, XrefRangeStart = 747841, XrefRangeEnd = 747841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsValid()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayEventId.NativeMethodInfoPtr_IsValid_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static GameplayEventId()
    {
      Il2CppClassPointerStore<GameplayEventId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameplayEventId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayEventId>.NativeClassPtr);
      GameplayEventId.NativeFieldInfoPtr_GameplayEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventId>.NativeClassPtr, nameof (GameplayEventType));
      GameplayEventId.NativeFieldInfoPtr_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventId>.NativeClassPtr, nameof (EventId));
      GameplayEventId.NativeMethodInfoPtr_Compare_Public_Boolean_GameplayEventId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventId>.NativeClassPtr, 100665862);
      GameplayEventId.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventId>.NativeClassPtr, 100665863);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEventId>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
