// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.PropertyBagRegistry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace Unity.Properties.Generated
{
  public class PropertyBagRegistry : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291953, XrefRangeEnd = 1292225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Initialize()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PropertyBagRegistry.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PropertyBagRegistry()
    {
      Il2CppClassPointerStore<PropertyBagRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "Unity.Properties.Generated", nameof (PropertyBagRegistry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyBagRegistry>.NativeClassPtr);
      PropertyBagRegistry.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyBagRegistry>.NativeClassPtr, 100670006);
    }

    public PropertyBagRegistry(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
