// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MinimapIconKey
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MinimapIconKey
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MapIconDataPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverridenCastleIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsSiegeIcon;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MinimapIconKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    [FieldOffset(0)]
    public PrefabGUID MapIconDataPrefabGuid;
    [FieldOffset(4)]
    public MapIconDrawMode DrawMode;
    [FieldOffset(8)]
    public int OverridenCastleIcon;
    [FieldOffset(12)]
    public bool IsSiegeIcon;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1271605, RefRangeEnd = 1271606, XrefRangeStart = 1271604, XrefRangeEnd = 1271605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(MinimapIconKey other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MinimapIconKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MinimapIconKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271606, XrefRangeEnd = 1271610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MinimapIconKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271610, XrefRangeEnd = 1271611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MinimapIconKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static MinimapIconKey()
    {
      Il2CppClassPointerStore<MinimapIconKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MinimapIconKey));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinimapIconKey>.NativeClassPtr);
      MinimapIconKey.NativeFieldInfoPtr_MapIconDataPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapIconKey>.NativeClassPtr, nameof (MapIconDataPrefabGuid));
      MinimapIconKey.NativeFieldInfoPtr_DrawMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapIconKey>.NativeClassPtr, nameof (DrawMode));
      MinimapIconKey.NativeFieldInfoPtr_OverridenCastleIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapIconKey>.NativeClassPtr, nameof (OverridenCastleIcon));
      MinimapIconKey.NativeFieldInfoPtr_IsSiegeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapIconKey>.NativeClassPtr, nameof (IsSiegeIcon));
      MinimapIconKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MinimapIconKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimapIconKey>.NativeClassPtr, 100668059);
      MinimapIconKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimapIconKey>.NativeClassPtr, 100668060);
      MinimapIconKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimapIconKey>.NativeClassPtr, 100668061);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MinimapIconKey>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
