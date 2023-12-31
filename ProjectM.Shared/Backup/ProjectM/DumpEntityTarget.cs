// Decompiled with JetBrains decompiler
// Type: ProjectM.DumpEntityTarget
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
  public struct DumpEntityTarget
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Dev;
    private static readonly System.IntPtr NativeFieldInfoPtr_Beta;
    private static readonly System.IntPtr NativeFieldInfoPtr_EA;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AlwaysFull_Public_Static_get_DumpEntityTarget_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AlwaysDefault_Public_Static_get_DumpEntityTarget_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Default_SkipEA_Public_Static_get_DumpEntityTarget_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Full_SkipEA_Public_Static_get_DumpEntityTarget_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Default_OnlyOnDev_Public_Static_get_DumpEntityTarget_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Full_OnlyOnDev_Public_Static_get_DumpEntityTarget_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DumpEntityLevel_DumpEntityLevel_DumpEntityLevel_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDumpLevel_Public_DumpEntityLevel_0;
    [FieldOffset(0)]
    public DumpEntityLevel Dev;
    [FieldOffset(4)]
    public DumpEntityLevel Beta;
    [FieldOffset(8)]
    public DumpEntityLevel EA;

    public static unsafe DumpEntityTarget AlwaysFull
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 733253, RefRangeEnd = 733254, XrefRangeStart = 733253, XrefRangeEnd = 733253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DumpEntityTarget.NativeMethodInfoPtr_get_AlwaysFull_Public_Static_get_DumpEntityTarget_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(DumpEntityTarget*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public static unsafe DumpEntityTarget AlwaysDefault
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DumpEntityTarget.NativeMethodInfoPtr_get_AlwaysDefault_Public_Static_get_DumpEntityTarget_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(DumpEntityTarget*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public static unsafe DumpEntityTarget Default_SkipEA
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DumpEntityTarget.NativeMethodInfoPtr_get_Default_SkipEA_Public_Static_get_DumpEntityTarget_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(DumpEntityTarget*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public static unsafe DumpEntityTarget Full_SkipEA
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DumpEntityTarget.NativeMethodInfoPtr_get_Full_SkipEA_Public_Static_get_DumpEntityTarget_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(DumpEntityTarget*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public static unsafe DumpEntityTarget Default_OnlyOnDev
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DumpEntityTarget.NativeMethodInfoPtr_get_Default_OnlyOnDev_Public_Static_get_DumpEntityTarget_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(DumpEntityTarget*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public static unsafe DumpEntityTarget Full_OnlyOnDev
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DumpEntityTarget.NativeMethodInfoPtr_get_Full_OnlyOnDev_Public_Static_get_DumpEntityTarget_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(DumpEntityTarget*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 220796, RefRangeEnd = 220803, XrefRangeStart = 220796, XrefRangeEnd = 220803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DumpEntityTarget(DumpEntityLevel dev, DumpEntityLevel beta, DumpEntityLevel ea)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &dev;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &beta;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &ea;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DumpEntityTarget.NativeMethodInfoPtr__ctor_Public_Void_DumpEntityLevel_DumpEntityLevel_DumpEntityLevel_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(33)]
    [CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DumpEntityLevel GetDumpLevel()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DumpEntityTarget.NativeMethodInfoPtr_GetDumpLevel_Public_DumpEntityLevel_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DumpEntityLevel*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DumpEntityTarget()
    {
      Il2CppClassPointerStore<DumpEntityTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DumpEntityTarget));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DumpEntityTarget>.NativeClassPtr);
      DumpEntityTarget.NativeFieldInfoPtr_Dev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DumpEntityTarget>.NativeClassPtr, nameof (Dev));
      DumpEntityTarget.NativeFieldInfoPtr_Beta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DumpEntityTarget>.NativeClassPtr, nameof (Beta));
      DumpEntityTarget.NativeFieldInfoPtr_EA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DumpEntityTarget>.NativeClassPtr, nameof (EA));
      DumpEntityTarget.NativeMethodInfoPtr_get_AlwaysFull_Public_Static_get_DumpEntityTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpEntityTarget>.NativeClassPtr, 100664790);
      DumpEntityTarget.NativeMethodInfoPtr_get_AlwaysDefault_Public_Static_get_DumpEntityTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpEntityTarget>.NativeClassPtr, 100664791);
      DumpEntityTarget.NativeMethodInfoPtr_get_Default_SkipEA_Public_Static_get_DumpEntityTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpEntityTarget>.NativeClassPtr, 100664792);
      DumpEntityTarget.NativeMethodInfoPtr_get_Full_SkipEA_Public_Static_get_DumpEntityTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpEntityTarget>.NativeClassPtr, 100664793);
      DumpEntityTarget.NativeMethodInfoPtr_get_Default_OnlyOnDev_Public_Static_get_DumpEntityTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpEntityTarget>.NativeClassPtr, 100664794);
      DumpEntityTarget.NativeMethodInfoPtr_get_Full_OnlyOnDev_Public_Static_get_DumpEntityTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpEntityTarget>.NativeClassPtr, 100664795);
      DumpEntityTarget.NativeMethodInfoPtr__ctor_Public_Void_DumpEntityLevel_DumpEntityLevel_DumpEntityLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpEntityTarget>.NativeClassPtr, 100664796);
      DumpEntityTarget.NativeMethodInfoPtr_GetDumpLevel_Public_DumpEntityLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpEntityTarget>.NativeClassPtr, 100664797);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DumpEntityTarget>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
