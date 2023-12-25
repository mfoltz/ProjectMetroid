// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.VoiceData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VoiceData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Voices;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entities;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_VoiceData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
    [FieldOffset(0)]
    public NativeList<VoiceEventOutput> Voices;
    [FieldOffset(16)]
    public NativeList<VoiceData.VoiceEntity> Entities;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1107356, RefRangeEnd = 1107358, XrefRangeStart = 1107350, XrefRangeEnd = 1107356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VoiceData(Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &allocator;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceData.NativeMethodInfoPtr__ctor_Public_Void_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1107364, RefRangeEnd = 1107365, XrefRangeStart = 1107358, XrefRangeEnd = 1107364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceData.NativeMethodInfoPtr_Clear_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1107383, RefRangeEnd = 1107384, XrefRangeStart = 1107365, XrefRangeEnd = 1107383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CopyFrom(VoiceData other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceData.NativeMethodInfoPtr_CopyFrom_Public_Void_VoiceData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1107390, RefRangeEnd = 1107392, XrefRangeStart = 1107384, XrefRangeEnd = 1107390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceData.NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VoiceData()
    {
      Il2CppClassPointerStore<VoiceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (VoiceData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoiceData>.NativeClassPtr);
      VoiceData.NativeFieldInfoPtr_Voices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceData>.NativeClassPtr, nameof (Voices));
      VoiceData.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceData>.NativeClassPtr, nameof (Entities));
      VoiceData.NativeMethodInfoPtr__ctor_Public_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceData>.NativeClassPtr, 100687725);
      VoiceData.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceData>.NativeClassPtr, 100687726);
      VoiceData.NativeMethodInfoPtr_CopyFrom_Public_Void_VoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceData>.NativeClassPtr, 100687727);
      VoiceData.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceData>.NativeClassPtr, 100687728);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VoiceData>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct VoiceEntity
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_StopWithSequence;
      [FieldOffset(0)]
      public Entity Entity;
      [FieldOffset(8)]
      public bool StopWithSequence;

      static VoiceEntity()
      {
        Il2CppClassPointerStore<VoiceData.VoiceEntity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceData>.NativeClassPtr, nameof (VoiceEntity));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoiceData.VoiceEntity>.NativeClassPtr);
        VoiceData.VoiceEntity.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceData.VoiceEntity>.NativeClassPtr, nameof (Entity));
        VoiceData.VoiceEntity.NativeFieldInfoPtr_StopWithSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceData.VoiceEntity>.NativeClassPtr, nameof (StopWithSequence));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VoiceData.VoiceEntity>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
