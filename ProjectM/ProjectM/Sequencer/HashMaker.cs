// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.HashMaker
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HashMaker
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Current;
    private static readonly System.IntPtr NativeFieldInfoPtr__Seed;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Generate_Public_Int32_Int32_Int32_Boolean_0;
    [FieldOffset(0)]
    public int _Current;
    [FieldOffset(4)]
    public readonly int _Seed;

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1098141, RefRangeEnd = 1098146, XrefRangeStart = 1098141, XrefRangeEnd = 1098141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HashMaker(int seed)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &seed;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HashMaker.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(30)]
    [CachedScanResults(RefRangeStart = 1098146, RefRangeEnd = 1098176, XrefRangeStart = 1098146, XrefRangeEnd = 1098146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int Generate(int currentHash, int currentSettingHash, bool use)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &currentHash;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentSettingHash;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &use;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HashMaker.NativeMethodInfoPtr_Generate_Public_Int32_Int32_Int32_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static HashMaker()
    {
      Il2CppClassPointerStore<HashMaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (HashMaker));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashMaker>.NativeClassPtr);
      HashMaker.NativeFieldInfoPtr__Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashMaker>.NativeClassPtr, nameof (_Current));
      HashMaker.NativeFieldInfoPtr__Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashMaker>.NativeClassPtr, nameof (_Seed));
      HashMaker.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashMaker>.NativeClassPtr, 100687209);
      HashMaker.NativeMethodInfoPtr_Generate_Public_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashMaker>.NativeClassPtr, 100687210);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HashMaker>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
