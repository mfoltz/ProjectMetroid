// Decompiled with JetBrains decompiler
// Type: ProjectM.InputHelper
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM
{
  public static class InputHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInputSystem_Public_Static_InputSystem_0;

    [CallerCount(148)]
    [CachedScanResults(RefRangeStart = 741522, RefRangeEnd = 741670, XrefRangeStart = 741491, XrefRangeEnd = 741522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe InputSystem GetInputSystem()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputHelper.NativeMethodInfoPtr_GetInputSystem_Public_Static_InputSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
    }

    static InputHelper()
    {
      Il2CppClassPointerStore<InputHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (InputHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputHelper>.NativeClassPtr);
      InputHelper.NativeMethodInfoPtr_GetInputSystem_Public_Static_InputSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputHelper>.NativeClassPtr, 100665434);
    }

    public InputHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
