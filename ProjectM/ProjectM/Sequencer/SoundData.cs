// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SoundData
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
  public struct SoundData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Sounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_Parameters;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entities;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_SoundData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
    [FieldOffset(0)]
    public NativeList<SoundOutput> Sounds;
    [FieldOffset(16)]
    public NativeList<SoundParameterOutput> Parameters;
    [FieldOffset(32)]
    public NativeList<Entity> Entities;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1107264, RefRangeEnd = 1107266, XrefRangeStart = 1107255, XrefRangeEnd = 1107264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SoundData(Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &allocator;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SoundData.NativeMethodInfoPtr__ctor_Public_Void_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1107275, RefRangeEnd = 1107277, XrefRangeStart = 1107266, XrefRangeEnd = 1107275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SoundData.NativeMethodInfoPtr_Clear_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1107296, RefRangeEnd = 1107297, XrefRangeStart = 1107277, XrefRangeEnd = 1107296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CopyFrom(SoundData other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SoundData.NativeMethodInfoPtr_CopyFrom_Public_Void_SoundData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1107306, RefRangeEnd = 1107308, XrefRangeStart = 1107297, XrefRangeEnd = 1107306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SoundData.NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SoundData()
    {
      Il2CppClassPointerStore<SoundData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SoundData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundData>.NativeClassPtr);
      SoundData.NativeFieldInfoPtr_Sounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundData>.NativeClassPtr, nameof (Sounds));
      SoundData.NativeFieldInfoPtr_Parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundData>.NativeClassPtr, nameof (Parameters));
      SoundData.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundData>.NativeClassPtr, nameof (Entities));
      SoundData.NativeMethodInfoPtr__ctor_Public_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundData>.NativeClassPtr, 100687717);
      SoundData.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundData>.NativeClassPtr, 100687718);
      SoundData.NativeMethodInfoPtr_CopyFrom_Public_Void_SoundData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundData>.NativeClassPtr, 100687719);
      SoundData.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundData>.NativeClassPtr, 100687720);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SoundData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
