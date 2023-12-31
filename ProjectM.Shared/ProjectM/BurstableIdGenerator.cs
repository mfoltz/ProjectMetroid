// Decompiled with JetBrains decompiler
// Type: ProjectM.BurstableIdGenerator
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BurstableIdGenerator
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__DataPtr;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_BurstableIdGenerator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeState_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_NewId_Public_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public System.IntPtr _DataPtr;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 746848, RefRangeEnd = 746852, XrefRangeStart = 746840, XrefRangeEnd = 746848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BurstableIdGenerator Create()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BurstableIdGenerator.NativeMethodInfoPtr_Create_Public_Static_BurstableIdGenerator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BurstableIdGenerator*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 746858, RefRangeEnd = 746862, XrefRangeStart = 746852, XrefRangeEnd = 746858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeState(int generatorState)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &generatorState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BurstableIdGenerator.NativeMethodInfoPtr_InitializeState_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 746869, RefRangeEnd = 746875, XrefRangeStart = 746862, XrefRangeEnd = 746869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int NewId()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BurstableIdGenerator.NativeMethodInfoPtr_NewId_Public_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 746881, RefRangeEnd = 746883, XrefRangeStart = 746875, XrefRangeEnd = 746881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BurstableIdGenerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BurstableIdGenerator()
    {
      Il2CppClassPointerStore<BurstableIdGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BurstableIdGenerator));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstableIdGenerator>.NativeClassPtr);
      BurstableIdGenerator.NativeFieldInfoPtr__DataPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstableIdGenerator>.NativeClassPtr, nameof (_DataPtr));
      BurstableIdGenerator.NativeMethodInfoPtr_Create_Public_Static_BurstableIdGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstableIdGenerator>.NativeClassPtr, 100665722);
      BurstableIdGenerator.NativeMethodInfoPtr_InitializeState_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstableIdGenerator>.NativeClassPtr, 100665723);
      BurstableIdGenerator.NativeMethodInfoPtr_NewId_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstableIdGenerator>.NativeClassPtr, 100665724);
      BurstableIdGenerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstableIdGenerator>.NativeClassPtr, 100665725);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BurstableIdGenerator>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
