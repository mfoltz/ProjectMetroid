// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.LocalizedStringBuilderBase
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LocalizedStringBuilderBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Key;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParameterIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParameterCount;
    private static readonly System.IntPtr NativeMethodInfoPtr_Build_Public_LocalizedString_EntityManager_Entity_0;
    [FieldOffset(0)]
    public LocalizationKey Key;
    [FieldOffset(16)]
    public int ParameterIndex;
    [FieldOffset(20)]
    public int ParameterCount;

    [CallerCount(46)]
    [CachedScanResults(RefRangeStart = 794631, RefRangeEnd = 794677, XrefRangeStart = 794602, XrefRangeEnd = 794631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizedString Build(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LocalizedStringBuilderBase.NativeMethodInfoPtr_Build_Public_LocalizedString_EntityManager_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new LocalizedString(pointer);
    }

    static LocalizedStringBuilderBase()
    {
      Il2CppClassPointerStore<LocalizedStringBuilderBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (LocalizedStringBuilderBase));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedStringBuilderBase>.NativeClassPtr);
      LocalizedStringBuilderBase.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringBuilderBase>.NativeClassPtr, nameof (Key));
      LocalizedStringBuilderBase.NativeFieldInfoPtr_ParameterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringBuilderBase>.NativeClassPtr, nameof (ParameterIndex));
      LocalizedStringBuilderBase.NativeFieldInfoPtr_ParameterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringBuilderBase>.NativeClassPtr, nameof (ParameterCount));
      LocalizedStringBuilderBase.NativeMethodInfoPtr_Build_Public_LocalizedString_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringBuilderBase>.NativeClassPtr, 100670068);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedStringBuilderBase>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
