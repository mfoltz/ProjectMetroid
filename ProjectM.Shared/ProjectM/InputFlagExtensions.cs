// Decompiled with JetBrains decompiler
// Type: ProjectM.InputFlagExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM
{
  public static class InputFlagExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ToNewFlag_Public_Static_InputFlag_InputFlag_Old_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToSyncedFlag_Public_Static_SyncedInputFlag_InputFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToInputFlag_Public_Static_InputFlag_SyncedInputFlag_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740855, XrefRangeEnd = 740887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe InputFlag ToNewFlag(this InputFlag_Old inputFlag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputFlag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputFlagExtensions.NativeMethodInfoPtr_ToNewFlag_Public_Static_InputFlag_InputFlag_Old_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(InputFlag*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 740887, RefRangeEnd = 740893, XrefRangeStart = 740887, XrefRangeEnd = 740887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SyncedInputFlag ToSyncedFlag(this InputFlag inputFlag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputFlag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputFlagExtensions.NativeMethodInfoPtr_ToSyncedFlag_Public_Static_SyncedInputFlag_InputFlag_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SyncedInputFlag*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe InputFlag ToInputFlag(this SyncedInputFlag inputFlag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputFlag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputFlagExtensions.NativeMethodInfoPtr_ToInputFlag_Public_Static_InputFlag_SyncedInputFlag_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(InputFlag*) IL2CPP.il2cpp_object_unbox(num);
    }

    static InputFlagExtensions()
    {
      Il2CppClassPointerStore<InputFlagExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (InputFlagExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputFlagExtensions>.NativeClassPtr);
      InputFlagExtensions.NativeMethodInfoPtr_ToNewFlag_Public_Static_InputFlag_InputFlag_Old_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFlagExtensions>.NativeClassPtr, 100665404);
      InputFlagExtensions.NativeMethodInfoPtr_ToSyncedFlag_Public_Static_SyncedInputFlag_InputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFlagExtensions>.NativeClassPtr, 100665405);
      InputFlagExtensions.NativeMethodInfoPtr_ToInputFlag_Public_Static_InputFlag_SyncedInputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFlagExtensions>.NativeClassPtr, 100665406);
    }

    public InputFlagExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
